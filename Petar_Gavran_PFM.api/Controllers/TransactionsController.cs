using Microsoft.AspNetCore.Mvc;
using Petar_Gavran_PFM.api.Models;
using PFM.Application.DTO;
using PFM.Application.Services;
using PFM.Application.Exceptions;
using PFM.Domain.Enums;
using PFM.Infrastructure.Services;
using System.ComponentModel;
using System.Text;

namespace Petar_Gavran_PFM.api.Controllers
{
    [ApiController]
    [Route("transactions")]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionImporter _importer;
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionImporter importer, ITransactionService transactionService)
        {
            _importer = importer;
            _transactionService = transactionService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTransactions(
        [FromQuery(Name = "start-date")] DateTime? startDate,
        [FromQuery(Name = "end-date")] DateTime? endDate,
        [FromQuery(Name = "kind")] string? kind,
        [FromQuery] int page = 1,
        [FromQuery(Name = "page-size")] int pageSize = 10)
        {
            if (!string.IsNullOrWhiteSpace(kind) && !Enum.TryParse<TransactionKind>(kind, true, out _))
            {
                return BadRequest($"Invalid kind value: '{kind}'.");
            }

            var result = await _transactionService.GetTransactionsAsync(startDate, endDate, kind, page, pageSize);
            return Ok(result);
        }

        [HttpPost("import")]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Import(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is required");

            using var stream = file.OpenReadStream();
            var result = await  _importer.ImportTransactionsAsync(stream);

            if (result.Errors.Any())
            {
                return BadRequest(new { errors = result.Errors });
            }

            return Ok(new { importedCount = result.ImportedCount });
        }

        [HttpPost("import-csv-text")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ImportCsvFromText([FromBody] string csvText)
        {
            if (string.IsNullOrWhiteSpace(csvText))
                return BadRequest(new { error = "CSV text cannot be empty." });

            using var stream = new MemoryStream(Encoding.UTF8.GetBytes(csvText));
            var result = await _importer.ImportTransactionsAsync(stream);

            if (result.Errors.Any())
                return BadRequest(new { errors = result.Errors });

            return Ok(new { importedCount = result.ImportedCount });
        }


        [HttpPost("{id}/categorize")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CategorizeTransaction(string id, [FromBody] CategorizeTransactionRequest request)
        {
            var success = await _transactionService.CategorizeTransactionAsync(id, request.CatCode);

            if (!success)
                return NotFound(new { message = "Transaction or category not found." });

            return Ok(new { message = "Transaction categorized successfully." });
        }

        [HttpPost("{id}/split")]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        public async Task<IActionResult> SplitTransaction(string id, [FromBody] List<TransactionSplitDto> splits)
        {
            try
            {
                var success = await _transactionService.SplitTransactionAsync(id, splits);
                if (!success)
                    return NotFound();

                return Ok();
            }
            catch (BusinessValidationException ex)
            {
                return StatusCode(440, new BusinessErrorResponse {
                    Problem = "split-invalid",
                    Description = "Invalid split request",
                    Message = ex.Message,
                    Details = $"Transaction ID: {id}"
                });
            }
        }


    }
}

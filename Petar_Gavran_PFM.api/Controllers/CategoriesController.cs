using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Petar_Gavran_PFM.api.Models;
using PFM.Application.Services;
using PFM.Infrastructure.Services;

namespace Petar_Gavran_PFM.api.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryImporter _importer;
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryImporter importer, ICategoryService categoryService)
        {
            _importer = importer;
            _categoryService = categoryService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCategories([FromQuery(Name = "parent-id")] string parentId = null)
        {
            var categories = await _categoryService.GetCategoriesAsync(parentId);

            return Ok(categories);
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
            var result = await _importer.ImportCategoriesAsync(stream);

            if (result.Errors.Any())
                return BadRequest(new { errors = result.Errors });

            return Ok(new { importedCount = result.ImportedCount });
        }
    }

}

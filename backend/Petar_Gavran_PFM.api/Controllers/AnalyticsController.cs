using Microsoft.AspNetCore.Mvc;
using Petar_Gavran_PFM.api.Models;
using PFM.Application.Services;
using PFM.Domain.Enums;

namespace Petar_Gavran_PFM.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnalyticsController : ControllerBase
    {
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsController(IAnalyticsService analyticsService)
        {
            _analyticsService = analyticsService;
        }

        [HttpGet("spending-analytics")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(BusinessErrorResponse), 440)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetSpendingAnalytics(
            [FromQuery] string? category,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate,
            [FromQuery] Direction? direction)
        {
            var result = await _analyticsService.GetSpendingAnalyticsAsync(category, startDate, endDate, direction);
            return Ok(result);
        }
    }

}

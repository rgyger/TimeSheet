using Microsoft.AspNetCore.Mvc;

namespace Services.TimeSheet.Server.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class TimeSheetController : ControllerBase
   {
      private readonly ILogger<TimeSheetController> _logger;

      public TimeSheetController(ILogger<TimeSheetController> logger)
      {
         _logger = logger;
      }

      [HttpGet]
      [Route("{accountId}")]
      [ProducesResponseType(StatusCodes.Status200OK)]
      [ProducesResponseType(StatusCodes.Status204NoContent)]
      [ProducesResponseType(StatusCodes.Status400BadRequest)]
      public async Task<IActionResult> Get()
      {
         
      }
   }
}

using HNG12S1T1.Services;
using Microsoft.AspNetCore.Mvc;

namespace HNG12S1T1.Controllers
{
    [ApiController]
    [Route("api")]
    public class NumberController : ControllerBase
    {
        private readonly NumberService _numberService;

        public NumberController (NumberService numberService)
        {
            _numberService = numberService;
        }

        [HttpGet("classify-number")]
        public async Task<IActionResult> Get([FromQuery] string number)
        {
            var result = await _numberService.ClassifyNumber(number);
            return Ok(result);
        }
    }
}

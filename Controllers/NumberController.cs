using HNG12S1T1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get([FromQuery] string? number)
        {
            if (string.IsNullOrWhiteSpace(number))
            {
                return BadRequest(new { number = "alphabet", error = true });
            }

            var result = await _numberService.ClassifyNumber(number);

            if (result == null)
            {
                return BadRequest(new { number = "alphabet", error = true });
            }

            return Ok(result);
        }
    }
}

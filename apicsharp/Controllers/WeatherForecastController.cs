using apicsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace apicsharp.Controllers
{
    [ApiController]
    [Route("[produto]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("produto")]
        public ActionResult Get(int id)
        {
            Produto produto = new Produto();
            try
            {
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}

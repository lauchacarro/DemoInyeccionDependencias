using DemoInyeccionDependencias.Strategies.Lazy;

using Microsoft.AspNetCore.Mvc;

namespace DemoInyeccionDependencias.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {

        private readonly BotServices _services;

        public BotController(BotServices services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _services.StockService.Value.GetStock();

            return Ok();
        }
    }
}

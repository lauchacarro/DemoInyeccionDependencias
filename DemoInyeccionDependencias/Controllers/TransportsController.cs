using DemoInyeccionDependencias.Strategies.Factory;

using Microsoft.AspNetCore.Mvc;

namespace DemoInyeccionDependencias.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportsController : ControllerBase
    {

        private readonly ITransportFactory _factory;

        public TransportsController(ITransportFactory factory)
        {
            _factory = factory;
        }

        [HttpGet]
        public IActionResult Get(TransportType trasportType)
        {
            ITransport transport = _factory.CreateTransport(trasportType);

            return Ok(transport);
        }
    }
}

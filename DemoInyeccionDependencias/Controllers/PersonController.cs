using DemoInyeccionDependencias.Strategies.Services;

using Microsoft.AspNetCore.Mvc;

namespace DemoInyeccionDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IEnumerable<IPersonService> _services;

        public PersonController(IEnumerable<IPersonService> services)
        {
            _services = services;
        }

        [HttpGet]
        public IActionResult DoSomething()
        {
            return Ok();
        }

    }
}

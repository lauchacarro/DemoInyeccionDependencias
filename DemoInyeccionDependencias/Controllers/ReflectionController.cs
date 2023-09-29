using DemoInyeccionDependencias.Strategies.Reflection;
using DemoInyeccionDependencias.Strategies.Services;

using Microsoft.AspNetCore.Mvc;

namespace DemoInyeccionDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReflectionController : ControllerBase
    {
        private readonly IProductService _services;

        public ReflectionController(IProductService services)
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

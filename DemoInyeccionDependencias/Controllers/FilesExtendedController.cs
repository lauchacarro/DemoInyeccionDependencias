using DemoInyeccionDependencias.Strategies.BlobStorageExtended;

using Microsoft.AspNetCore.Mvc;

namespace DemoInyeccionDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesExtendedController : ControllerBase
    {
        private readonly IFileExtendedService _service;

        public FilesExtendedController(IFileExtendedService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult DoSomething()
        {
            return Ok();
        }
    }
}

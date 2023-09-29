using DemoInyeccionDependencias.Strategies.BlobStorage;

using Microsoft.AspNetCore.Mvc;

namespace DemoInyeccionDependencias.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _service;

        public FilesController(IFileService service)
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

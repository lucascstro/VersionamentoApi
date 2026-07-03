using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2")]
    [ApiController]
    public class Order2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Order Versão 2");
    }
}
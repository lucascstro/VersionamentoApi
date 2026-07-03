using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok("Order Versão 1");
    }
}

using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("2")]
    [ApiController]
    public class User2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult Get() => Ok("Versão 2");
    }
}
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioning.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get() => Ok("Versão 1");
        
    }
}
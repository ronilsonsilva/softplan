using Microsoft.AspNetCore.Mvc;

namespace Softplan.Calculadora.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterUrl()
        {
            return Ok("https://github.com/ronilsonsilva/softplan");
        }
    }
}

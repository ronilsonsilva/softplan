using Microsoft.AspNetCore.Mvc;
using Softplan.Calculadora.Application.Contracts;
using Softplan.Calculadora.Domain.Commands;
using System.Threading.Tasks;

namespace Softplan.Calculadora.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ICalculaJurosApplication _calculaJurosApplication;

        public CalculaJurosController(ICalculaJurosApplication calculaJurosApplication)
        {
            _calculaJurosApplication = calculaJurosApplication;
        }

        [HttpPost]
        public async Task<IActionResult> CalculaJuros([FromBody]CalculaJurosCommand command)
        {
            return Ok(await this._calculaJurosApplication.Calcula(command));
        }
    }
}

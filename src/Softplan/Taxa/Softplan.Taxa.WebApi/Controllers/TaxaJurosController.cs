using Microsoft.AspNetCore.Mvc;
using Softplan.Taxa.Application.Contracts;
using System;
using System.Threading.Tasks;

namespace Softplan.Taxa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosApplication _taxaJurosApplication;

        public TaxaJurosController(ITaxaJurosApplication taxaJurosApplication)
        {
            _taxaJurosApplication = taxaJurosApplication;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTaxa()
        {
            return Ok(Decimal.Parse("0,1"));
        }
    }
}

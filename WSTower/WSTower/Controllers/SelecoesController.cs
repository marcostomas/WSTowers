using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSTower.Repositories;

namespace WSTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SelecoesController : ControllerBase
    {
        SelecaoRepository _Selecao { get; set; }

        public SelecoesController()
        {
            _Selecao = new SelecaoRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_Selecao.ListarComJogador());
        }
    }
}
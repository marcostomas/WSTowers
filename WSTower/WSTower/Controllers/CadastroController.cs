using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSTower.Domains;
using WSTower.Repositories;

namespace WSTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        UsuarioRepository _Usuario { get; set; }

        public CadastroController()
        {
            _Usuario = new UsuarioRepository();
        }
        
        [HttpPost]
        public IActionResult Cadastro(Usuario usuarioNovo)
        {
            if (usuarioNovo.Email == null || usuarioNovo.Senha == null || usuarioNovo.Apelido == null||usuarioNovo.Nome==null)
            {
                return BadRequest("Preencha todos os campos");
            }
            else
            {
                _Usuario.Cadastar(usuarioNovo);
                return Ok("Usuario cadastrado");
            }
        }

    }
}
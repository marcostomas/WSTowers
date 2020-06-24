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
    public class LoginController : ControllerBase
    {
            UsuarioRepository _Usuario { get; set; }

        public LoginController()
        {
            _Usuario = new UsuarioRepository();
        }
        [HttpPost]
        public IActionResult Login(Usuario usuarioLogin)
        {
           Usuario UserAchado=_Usuario.Login(usuarioLogin.Email,usuarioLogin.Senha,usuarioLogin.Apelido);

            if (UserAchado != null)
            {
                return Ok("Bem vindo:"+UserAchado.Apelido);
            }
            

            return BadRequest("Usuario ou senha incorreto");

        }
    }
        
}
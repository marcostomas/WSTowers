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
    public class UsuariosController : ControllerBase
    {
        UsuarioRepository _Usuario { get; set; }

        public UsuariosController()
        {
            _Usuario = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult ListarUsuario()
        {
            return Ok(_Usuario.ListarTodos());
        }
    }
}
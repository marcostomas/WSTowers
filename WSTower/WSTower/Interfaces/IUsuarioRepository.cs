using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Domains;

namespace WSTower.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastar(Usuario usuario);

        List<Usuario> ListarTodos();

        Usuario Login(string email,string senha,string apelido);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        TowerContext dbx = new TowerContext();

        public void Cadastar(Usuario usuario)
        {
            dbx.Usuario.Add(usuario);

            dbx.SaveChanges();
        }

        public List<Usuario> ListarTodos()
        {
            return dbx.Usuario.ToList();
        }

        public Usuario Login(string email, string senha, string apelido)
        {
            if (apelido == null)
            {
                 Usuario UsuarioPorEmail = dbx.Usuario.FirstOrDefault(u => u.Senha == senha && u.Email == email);
                return UsuarioPorEmail;
            }
            else
            {
               return dbx.Usuario.FirstOrDefault(u => u.Senha == senha && u.Apelido==apelido);
                
            }
        }
    }
}

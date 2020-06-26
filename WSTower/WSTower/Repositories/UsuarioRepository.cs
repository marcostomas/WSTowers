using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Domains;
using WSTower.Interfaces;
using WSTower.ViewModel;

namespace WSTower.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        TowerContext dbx = new TowerContext();


        public void AlterarSenha(int id, LoginViewModel login)
        {
            Usuario usuarioBuscado = dbx.Usuario.Find(id);

            if (usuarioBuscado.Senha != null)
            {
                usuarioBuscado.Senha = login.Senha;
            }

            dbx.Update(usuarioBuscado);

            dbx.SaveChanges();
        }

        public void AlterarUsuario(int id, Usuario UsuarioAtualizado)
        {
            Usuario usuarioBuscado = dbx.Usuario.Find(id);

            if (UsuarioAtualizado.Email != null)
            {
                usuarioBuscado.Email = UsuarioAtualizado.Email;
            }

            if (UsuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = UsuarioAtualizado.Senha;
            }

            if (UsuarioAtualizado.Foto != null)
            {
                usuarioBuscado.Foto = UsuarioAtualizado.Foto;
            }

            if (UsuarioAtualizado.Nome != null)
            {
                usuarioBuscado.Nome = UsuarioAtualizado.Nome;
            }

            if (UsuarioAtualizado.Apelido != null)
            {
                usuarioBuscado.Apelido = UsuarioAtualizado.Apelido;
            }

            dbx.Update(usuarioBuscado);

            dbx.SaveChanges();
        }


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
                 Usuario UsuarioPorEmail = dbx.Usuario.First(u =>u.Email == email);               
                return UsuarioPorEmail;
            }
            else
            {
               return dbx.Usuario.FirstOrDefault(u=>u.Apelido==apelido);
            }
        }

        
    }
}

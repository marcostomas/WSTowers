using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTower.Domains;
using WSTower.Interfaces;

namespace WSTower.Repositories
{
    public class JogadorRepository: IJogadorRepository
    {
        TowerContext ctx = new TowerContext();


        public List<Jogador> ListarTodos()
        {
            return ctx.Jogador.ToList();
        }

        public Jogador BuscarPorId(int id)
        {
            Jogador jogadorBuscado = ctx.Jogador.FirstOrDefault(j=>j.Id==id);

            if (jogadorBuscado != null)
            {
                return jogadorBuscado;
            }

            return null;
    
        }

      




       
    }
}

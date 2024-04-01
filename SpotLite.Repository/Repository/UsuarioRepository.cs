using SpotLite.Domain.Conta.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>
    {
        public SpotLiteContext Context { get; set; }

        public UsuarioRepository(SpotLiteContext context) : base(context)
        {
            Context = context;
        }

        //Caso não implementasse o EF Proxies, assim seria a implementação:
        //public Usuario GetById(Guid id)
        //{
        //    return this.Context.Usuarios
        //               .Include(x => x.Assinaturas) //Caso não esteja usando lazy loading
        //               .Include(x => x.Playlists)
        //               .Include(x => x.Notificacoes)
        //               //.AsSplitQuery() //Quebra a consulta por cada tipo
        //               .FirstOrDefault(x => x.Id == id);
        //}


    }
}


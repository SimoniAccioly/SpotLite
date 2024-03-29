using SpotLite.Domain.Financeiro.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Repository
{
    public class PlanoRepository : RepositoryBase<Plano>
    {
        public SpotLiteContext Context { get; set; }

        public PlanoRepository(SpotLiteContext context) : base(context)
        {
            Context = context;
        }


    }
}

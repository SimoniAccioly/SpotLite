using SpotLite.Domain.PlayList.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Repository
{
    public class BandaRepository : RepositoryBase<Banda>
    {
        public BandaRepository(SpotLiteContext context) : base(context)
        {
        }
    }
}

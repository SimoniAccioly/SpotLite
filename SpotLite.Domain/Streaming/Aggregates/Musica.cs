using SpotLite.Domain.Core.ValueObjects;
using SpotLite.Domain.Streaming.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Domain.Streaming.Aggregates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Duracao Duracao { get; set; }
    }
}

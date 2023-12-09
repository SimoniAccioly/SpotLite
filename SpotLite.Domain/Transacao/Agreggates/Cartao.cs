using SpotLite.Domain.Core.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Domain.Transacao.Agreggates
{
    public class Cartao
    {
        public Guid Id { get; set; }
        public Boolean Ativo { get; set; }
        public Monetario Limite { get; set; }
        public String Numero { get; set; }
        public DateTime Validade { get; set; }
        public int CVV { get; set; }
        public List<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}

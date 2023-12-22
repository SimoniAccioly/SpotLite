using SpotLite.Domain.Core.ValueObject;
using SpotLite.Domain.Financeiro.ValueObject;

namespace SpotLite.Domain.Financeiro.Agreggates
{
    public class Transacao
    {
        public Guid Id { get; set; }
        public DateTime DtTransacao { get; set; }
        public Monetario Valor { get; set; }
        public String Descricao { get; set; }
        public Merchant Merchant { get; set; }

    }
}

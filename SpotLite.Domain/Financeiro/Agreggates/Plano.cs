using SpotLite.Domain.Core.ValueObject;


namespace SpotLite.Domain.Financeiro.Agreggates
{
    public class Plano
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Monetario Valor { get; set; }

    }
}

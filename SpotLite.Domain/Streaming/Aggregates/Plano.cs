using SpotLite.Domain.Core.ValueObject;


namespace SpotLite.Domain.Streaming.Aggregates
{
    public class Plano
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public Monetario Valor { get; set; }

    }
}

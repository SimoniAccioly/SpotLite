using SpotLite.Domain.Streaming.Aggregates;


namespace SpotLite.Domain.Conta.Aggregates
{
    public class Assinatura
    {
        public Guid Id { get; set; }
        public Plano Plano { get; set; }
        public Boolean Ativo { get; set; }
        public DateTime DtAtivacao { get; }
    }
}

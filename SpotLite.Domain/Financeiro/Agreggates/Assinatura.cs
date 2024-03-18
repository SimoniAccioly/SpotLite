namespace SpotLite.Domain.Financeiro.Agreggates
{
    public class Assinatura
    {
        public Guid Id { get; set; }
        public virtual Plano? Plano { get; set; }
        public bool Ativo { get; set; }
        public DateTime DtAtivacao { get; set; }
    }
}

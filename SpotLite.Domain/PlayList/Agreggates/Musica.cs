using SpotLite.Domain.PlayList.ValueObjects;

namespace SpotLite.Domain.PlayList.Agreggates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Duracao Duracao { get; set; }
    }
}

using SpotLite.Domain.Streaming.ValueObjects;

namespace SpotLite.Domain.Streaming.Agreggates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Duracao Duracao { get; set; }
    }
}

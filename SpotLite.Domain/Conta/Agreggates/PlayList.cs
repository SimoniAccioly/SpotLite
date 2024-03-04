using SpotLite.Domain.Streaming.Agreggates;


namespace SpotLite.Domain.Conta.Agreggates
{
    public class PlayList
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Boolean Publica { get; set; }
        public Usuario Usuario { get; set; }
        public List<Musica> Musicas { get; set; }
        public DateTime DtCriacao { get; set; }
    }
}

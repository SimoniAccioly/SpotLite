using SpotLite.Domain.Streaming.Aggregates;

namespace SpotLite.Domain.PlayList.Aggregates
{
    public class Album
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Musica> Musica { get; set; } = new List<Musica>();

        public void AdicionarMusica(Musica musica) =>
           Musica.Add(musica);
        public void AdicionarMusica(List<Musica> musica) =>
            Musica.AddRange(musica);
    }
}

using SpotLite.Domain.Conta.Agreggates;
using SpotLite.Domain.PlayList.ValueObjects;

namespace SpotLite.Domain.PlayList.Agreggates
{
    public class Musica
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public Duracao Duracao { get; set; }
        public bool Favorito { get; set; }
        public virtual IList<SpotLite.Domain.Conta.Agreggates.PlayList> Playlists { get; set; } = new List<SpotLite.Domain.Conta.Agreggates.PlayList>();
    }
}

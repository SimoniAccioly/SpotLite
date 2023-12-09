using SpotLite.Domain.Conta.ValueObjects;
using SpotLite.Domain.Transacao.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Domain.Conta.Aggregates
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public string Senha { get; set; }
        public DateTime DtNascimento { get; set; }
        public string CPF { get; set; }
        public List<Cartao> Cartoes { get; set; } = new List<Cartao>();
        public List<Assinatura> Assinaturas { get; set; } = new List<Assinatura>();
        public List<PlayList> Playlists { get; set; } = new List<PlayList>();

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Mapping.Conta
{
    public class PlayListMapping : IEntityTypeConfiguration<SpotLite.Domain.Conta.Agreggates.PlayList>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SpotLite.Domain.Conta.Agreggates.PlayList> builder)
        {
            builder.ToTable(nameof(SpotLite.Domain.Conta.Agreggates.PlayList));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Publica).IsRequired();
            builder.Property(x => x.DtCriacao).IsRequired();

            builder.HasMany(x => x.Musicas).WithMany(x => x.Playlists);
        }

    }
}

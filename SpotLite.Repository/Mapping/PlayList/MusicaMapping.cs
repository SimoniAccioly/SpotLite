﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotLite.Domain.PlayList.Agreggates;
using SpotLite.Domain.PlayList.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Mapping.PlayList
{
    public class MusicaMapping : IEntityTypeConfiguration<Musica>
    {
        public void Configure(EntityTypeBuilder<Musica> builder)
        {
            builder.ToTable(nameof(Musica));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Favorito);
            builder.OwnsOne<Duracao>(d => d.Duracao, c =>
            {
                c.Property(x => x.Valor).IsRequired().HasMaxLength(50);
            });
        }
    }
}

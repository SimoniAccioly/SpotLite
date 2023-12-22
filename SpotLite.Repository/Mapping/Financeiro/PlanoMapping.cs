using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpotLite.Domain.Core.ValueObject;
using SpotLite.Domain.Financeiro.Agreggates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Mapping.Financeiro
{
    public class PlanoMapping : IEntityTypeConfiguration<Plano>
    {
        public void Configure(EntityTypeBuilder<Plano> builder)
        {
            builder.ToTable(nameof(Plano));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(50);

            builder.OwnsOne<Monetario>(d => d.Valor, c =>
            {
                c.Property(x => x.Valor).HasColumnName("ValorPlano").IsRequired().HasMaxLength(50);
            });
        }
    }
}

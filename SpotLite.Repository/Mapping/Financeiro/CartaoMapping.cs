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
    public class CartaoMapping : IEntityTypeConfiguration<Cartao>
    {
        public void Configure(EntityTypeBuilder<Cartao> builder)
        {
            builder.ToTable(nameof(Cartao));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Ativo).IsRequired();
            builder.Property(x => x.Limite).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Validade).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CVV).IsRequired().HasMaxLength(50);

            builder.OwnsOne<Monetario>(d => d.Limite, c =>
            {
                c.Property(x => x.Valor).HasColumnName("Limite").IsRequired();
            });

            builder.HasMany<Transacao>(x => x.Transacoes).WithOne();
        }
    }
}

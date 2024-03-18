using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotLite.Repository.Mapping.Conta
{
    public class Usuario : IEntityTypeConfiguration<Domain.Conta.Agreggates.Usuario>
    {
        public void Configure(EntityTypeBuilder<Domain.Conta.Agreggates.Usuario> builder)
        {
            builder.ToTable(nameof(Usuario));

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Senha).IsRequired().HasMaxLength(100);
            builder.Property(x => x.DtNascimento).IsRequired();
            builder.Property(x => x.CPF).IsRequired();

            builder.HasMany(x => x.Cartoes).WithOne();
            builder.HasMany(x => x.Assinaturas).WithOne();
            builder.HasMany(x => x.PlayLists).WithOne(x => x.Usuario);
        }
    }
}

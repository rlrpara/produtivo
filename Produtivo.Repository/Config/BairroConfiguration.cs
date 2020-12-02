using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produtivo.Dominio.Entidades;

namespace Produtivo.Repositorio.Config
{
    public class BairroConfiguration : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder
                .HasKey(x => x.Codigo);

            builder
                .Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(x => x.CreatedAt)
                .HasColumnType("timestamp without time zone")
                .HasDefaultValueSql("getdate()")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasDefaultValueSql("getutcdate()")
                .ValueGeneratedOnAddOrUpdate(); ;

            builder
                .ToTable("Bairro");
        }
    }
}

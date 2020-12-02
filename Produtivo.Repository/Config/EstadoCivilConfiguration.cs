using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produtivo.Dominio.Entidades;

namespace Produtivo.Repositorio.Config
{
    public class EstadoCivilConfiguration : IEntityTypeConfiguration<EstadoCivil>
    {
        public void Configure(EntityTypeBuilder<EstadoCivil> builder)
        {
            builder
                .HasKey(x => x.Codigo);

            builder
                .Property(x => x.Descricao)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(x => x.CreatedAt)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.UpdatedAt)
                .HasColumnType("TIMESTAMP")
                .HasDefaultValueSql("CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                .ValueGeneratedOnAddOrUpdate();

            builder
                .ToTable("EstadoCivil");
        }
    }
}

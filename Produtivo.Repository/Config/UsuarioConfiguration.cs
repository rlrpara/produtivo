using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produtivo.Dominio.Entidades;

namespace Produtivo.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(x => x.Codigo);

            builder
                .Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(x => x.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(x => x.Whatsapp)
                .IsRequired()
                .HasMaxLength(15);

            builder
                .Property(x => x.Celular)
                .IsRequired()
                .HasMaxLength(15);

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
                .ToTable("Usuario");

        }
    }
}

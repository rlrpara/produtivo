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
                .HasColumnType("timestamp without time zone")
                .HasDefaultValueSql("getdate()")
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.UpdatedAt)
                .HasColumnType("timestamp without time zone")
                .HasDefaultValueSql("getutcdate()")
                .ValueGeneratedOnAddOrUpdate();

            builder
                .HasMany(u => u.Lancamentos)
                .WithOne(l => l.Usuarios)
                .HasForeignKey(u => u.UsuarioId);

            builder
                .ToTable("Usuario");

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Produtivo.Dominio.Entidades;

namespace Produtivo.Repositorio.Config
{
    public class LancamentoConfiguration : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder
                .HasKey(x => x.Codigo);

            builder
                .Property(x => x.Documento)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(x => x.Referencia)
                .IsRequired()
                .HasMaxLength(255);

            builder
                .Property(x => x.Vencimento)
                .HasColumnType("TIMESTAMP")
                .IsRequired();

            builder
                .Property(x => x.EnviadoFinanceiro)
                .HasColumnType("TIMESTAMP");

            builder
                .Property(x => x.Responsavel)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(x => x.Valor)
                .IsRequired();

            builder
                .Property(x => x.Pagamento)
                .HasColumnType("TIMESTAMP");

            builder
                .Property(x => x.Pago)
                .IsRequired()
                .HasDefaultValue(false);

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
                .ToTable("Lancamento");
        }
    }
}

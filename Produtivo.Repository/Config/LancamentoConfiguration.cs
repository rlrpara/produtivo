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
                .HasColumnType("timestamp without time zone");

            builder
                .Property(x => x.EnviadoFinanceiro)
                .HasColumnType("timestamp without time zone");

            builder
                .Property(x => x.Responsavel)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(x => x.Valor);

            builder
                .Property(x => x.Pagamento)
                .HasColumnType("timestamp without time zone");

            builder
                .Property(x => x.Pago)
                .IsRequired()
                .HasDefaultValue(false);

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
                .ToTable("Lancamento");
        }
    }
}

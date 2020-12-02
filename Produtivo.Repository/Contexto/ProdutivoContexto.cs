using Microsoft.EntityFrameworkCore;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Config;

namespace Produtivo.Repositorio.Contexto
{
    public class ProdutivoContexto : DbContext
    {
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Lancamento> Lancamento { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public ProdutivoContexto(DbContextOptions options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BairroConfiguration());
            modelBuilder.ApplyConfiguration(new EscolaridadeConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoCivilConfiguration());
            modelBuilder.ApplyConfiguration(new LancamentoConfiguration());
            modelBuilder.ApplyConfiguration(new SexoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

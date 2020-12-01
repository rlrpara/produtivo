using Microsoft.EntityFrameworkCore;
using Produtivo.Dominio.Entidades;
using Produtivo.Repositorio.Config;

namespace Produtivo.Repositorio.Contexto
{
    public class ProdutivoContexto : DbContext
    {
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Escolaridade> Escolaridades { get; set; }
        public DbSet<EstadoCivil> EstadoCivis { get; set; }
        public DbSet<Municipe> Municipes { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public ProdutivoContexto(DbContextOptions options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BairroConfiguration());
            modelBuilder.ApplyConfiguration(new EscolaridadeConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoCivilConfiguration());
            modelBuilder.ApplyConfiguration(new MunicipesConfiguration());
            modelBuilder.ApplyConfiguration(new SexoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

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

            modelBuilder.Entity<Escolaridade>().HasData(
                new Escolaridade() { Codigo = 1, Descricao = "Fundamental - Incompleto" },
                new Escolaridade() { Codigo = 2, Descricao = "Fundamental - Completo" },
                new Escolaridade() { Codigo = 3, Descricao = "Médio - Incompleto" },
                new Escolaridade() { Codigo = 4, Descricao = "Médio - Completo" },
                new Escolaridade() { Codigo = 5, Descricao = "Superior - Incompleto" },
                new Escolaridade() { Codigo = 6, Descricao = "Superior - Completo" },
                new Escolaridade() { Codigo = 7, Descricao = "Pós-graduação (Lato senso) - Incompleto" },
                new Escolaridade() { Codigo = 8, Descricao = "Pós-graduação (Lato senso) - Completo" },
                new Escolaridade() { Codigo = 9, Descricao = "Pós-graduação (Stricto sensu, nível mestrado) - Incompleto" },
                new Escolaridade() { Codigo = 10, Descricao = "Pós-graduação (Stricto sensu, nível mestrado) - Completo" },
                new Escolaridade() { Codigo = 11, Descricao = "Pós-graduação (Stricto sensu, nível doutor) - Incompleto" },
                new Escolaridade() { Codigo = 12, Descricao = "Pós-graduação (Stricto sensu, nível doutor) - Completo" }
            );

            modelBuilder.Entity<EstadoCivil>().HasData(
                new EstadoCivil() { Codigo = 1, Descricao = "Solteiro" },
                new EstadoCivil() { Codigo = 2, Descricao = "Casado" },
                new EstadoCivil() { Codigo = 3, Descricao = "Viúvo" },
                new EstadoCivil() { Codigo = 4, Descricao = "Separado judicialmente" },
                new EstadoCivil() { Codigo = 5, Descricao = "Divorciado" }
            );

            modelBuilder.Entity<Sexo>().HasData(
                new Sexo() { Codigo = 1, Descricao = "Masculino" },
                new Sexo() { Codigo = 2, Descricao = "Feminino" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

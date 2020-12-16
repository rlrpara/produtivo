using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Produtivo.Dominio.Contratos;
using Produtivo.Repositorio.Contexto;
using Produtivo.Repositorio.Repositorios;

namespace Produtivo.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProdutivoContexto>(
                option => option.UseMySql(Configuration.GetConnectionString("ProdutivoDb"))
            );

            services.AddScoped<IBairroRepositorio, BairroRepositorio>();
            services.AddScoped<IEscolaridadeRepositorio, EscolaridadeRepositorio>();
            services.AddScoped<IEstadoCivilRepositorio, EstadoCivilRepositorio>();
            services.AddScoped<ILancamentoRepositorio, LancamentoRepositorio>();
            services.AddScoped<ISexoRepositorio, SexoRepositorio>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

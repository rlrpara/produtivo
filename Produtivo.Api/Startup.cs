using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Produtivo.Domain.Interface;
using Produtivo.Repository.Repository;

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
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddScoped<IBairroRepository, BairroRepository>();
            services.AddScoped<IEscolaridadeRepository, EscolaridadeRepository>();
            services.AddScoped<IEstadoCivilRepository, EstadoCivilRepository>();
            services.AddScoped<ILancamentoRepository, LancamentoRepository>();
            services.AddScoped<ISexoRepository, SexoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

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

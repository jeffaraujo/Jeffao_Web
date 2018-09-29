using Jeffao_Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jeffao_Web
{
    public class Startup
    {
        //Injeção de Dependencia
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";

            //Selecionando o Provider do EF Core
            services.AddDbContext<PerguntasContext>(o => o.UseSqlServer(connection));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            //Middleware para usar arquivos estático (Imagens)
            app.UseStaticFiles();

            if(env.IsDevelopment())
                app.UseDeveloperExceptionPage(); //Middleware para mostra erros


            //Configuração de Middleware
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Ola Fiap!!!");
            //});
            //Configurando rota
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
                //Sempre que montar as rotas, montar da mais específica (Em cima) para mais genérica (Em baixo)
                //routes.MapRoute(
                //    name: "autor",
                //    template: "autor/{nome}",
                //    defaults:new { controller="Autor", action="Index" }
                //    );

                //routes.MapRoute(
                //    name: "autoresDoAno",
                //    template: "{ano:int}/autor",
                //    defaults: new { controller = "Autor", action = "ListaDosAutoresDoAno" }
                //    );

                //routes.MapRoute(
                //    name: "topicosdacategoria",
                //    template: "{categoria}/{topico}",
                //    defaults: new { controller = "Topicos", action = "Index" }
                //    );

            });
        }




    }
}

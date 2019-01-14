using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace HostingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                // .Configure(app => {
                //     app.Run(context => context.Response.WriteAsync("Olá mundo!"));
                // })
                .UseStartup<Startup>()
                .Build()
            ;
            
            host.Run();
        }
    }

    internal class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Use(async (context, next) => {
                await context.Response.WriteAsync("Trabalhando com a classe Startup");
            });
        }
    }
}

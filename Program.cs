using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Jeffao_Web
{
    class Program
    {
        static void Main(string[] args)
        {
            //Argumentos dizendo se está em Debug ou Release
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
          

            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }
    }

}

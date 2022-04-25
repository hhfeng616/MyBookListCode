//////////////////////////////////////////////////////////////////
//
//   PROGRAMMING ASP.NET CORE
//   Dino Esposito
//   
//   Ch03 - Bootstrapping ASP.NET MVC 
//   Routes
//

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace Ch03.Routes
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            // DEMO:
            //services.AddMvc(options =>
            //{
            //    options.ModelBinderProviders.Add(new SmartDateBinderProvider());
            //    options.SslPort = 344;
            //});
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    "I'd rather say there are no configured routes here.");
            });
        }
    }
}

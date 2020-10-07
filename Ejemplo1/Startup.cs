using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Ejemplo1
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            //services.AddMvcCore();
            services.AddCors();

            services.AddSingleton<IAmigoAlmacen, MocikAmigoRepositorio>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger <Startup> logger)
        {



            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions d = new DeveloperExceptionPageOptions()
                {
                    SourceCodeLineCount = 2
                };

                app.UseDeveloperExceptionPage(d);
            }
            else if (env.IsProduction() || env.IsStaging())
            {
                app.UseExceptionHandler("/Error");
            }


           app.UseStaticFiles();
            app.UseRouting();
            app.UseCors();
           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });

            app.Run(async (context) =>
                {


                    await context.Response.WriteAsync("Texto");

                });





        }
    }
}

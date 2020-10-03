using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

            //DefaultFilesOptions d = new DefaultFilesOptions();
            //d.DefaultFileNames.Clear();
            //d.DefaultFileNames.Add("nodefault.html");
            //app.UseDefaultFiles(d);
            app.UseDefaultFiles();
            app.UseStaticFiles();


            app.Run(async (context) => 
            {

                throw new Exception("Cachis error fatal.");
                await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
              
            });



        }
    }
}

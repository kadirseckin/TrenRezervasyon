using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrenRezervasyon.BusinessLayer;
using TrenRezervasyon.BusinessLayer.Abstract;

namespace TrenRezervasyon.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<IRezervasyonService, RezervasyonManager>();
            services.AddSwaggerDocument(config=> {
                config.PostProcess = (doc =>
                {
                    doc.Info.Title = "Tren Rezervasyon API";
                    doc.Info.Contact = new NSwag.OpenApiContact()
                    {
                        Name="Kadir Doðuþ Seçkin",
                        Email="seckinkadir@outlook.com",
                    };
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                                         
            app.UseRouting();
            
            //for swagger
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           
        }
    }
}

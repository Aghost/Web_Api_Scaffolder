using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using PROJECTNAME.Core;
using PROJECTNAME.Data;
using PROJECTNAME.Business;

namespace PROJECTNAME.App
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

            // UNTESTED
            services.AddCors();
            services.AddControllers();

            services.AddDbContext<PROJECTNAMEDbContext>(opts => {
                    opts.EnableDetailedErrors();
                    opts.UseNpgsql(Configuration.GetConnectionString("PROJECTNAME"));
            });

            /*
             * Transient = dispose of data between subsequent requests
             * Scoped = lifetime of entire http request
             * Singleton = only 1 instance will be used
            */
            services.AddTransient<IMovieService, MovieService>(); //Transient?
            services.AddTransient<IITEMService, ITEMService>();
            //services.AddTransient<ICHILDITEM, CHILDITEMService>(); // no service for yet

            services.AddSingleton<IEnglishNumberService, EnglishNumberService>();
            services.AddSingleton<ICalculatePiService, CalculatePiService>();

            /* services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "PROJECTNAMEProject.Web", Version = "v1" });
            }); */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                //app.UseSwagger();
                //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DependancyInjectionProject.Web v1"));
            }

            //TODO if (env. is not development)
            //  app.UseHttpsRedirection();

            // app.UseStaticFiles();
            app.UseRouting();

            // UNTESTED
            app.UseCors(builder => builder
                    .WithOrigins(
                        "http://localhost:5000"
                    )

                    .AllowAnyMethod()
                    .AllowAnyHeader()
            );
            // /UNTESTED

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllersRoute(name: "default", pattern: "{controller=Home}/action=Index}/{id?}");
                endpoints.MapControllers();
            });
        }
    }
}

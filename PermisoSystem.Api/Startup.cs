using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PermisoSystem.BL.Middlewares;
using PermisoSystem.BL.Profiles;
using PermisoSystem.BL.UnitOfWork.Repositories;
using PermisoSystem.Data;
using PermisoSystem.Data.ExtensionsMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermisoSystem.Api
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

            services.AddDbContext<PermisoSystemContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("connection"),
                builder => builder.MigrationsAssembly("PermisoSystem.Api")));

            services.AddAutoMapper(config =>
                config.AddMaps(typeof(ProfileConfig).Assembly));

            services.AddScoped<PermisoRepository>();
            services.AddScoped<TipoPermisoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.CreateDatabase();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(cors => cors
                                    .AllowAnyHeader()
                                    .AllowAnyMethod()
                                    .AllowAnyOrigin());

            app.UseMiddleware<ErrorHandlerMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

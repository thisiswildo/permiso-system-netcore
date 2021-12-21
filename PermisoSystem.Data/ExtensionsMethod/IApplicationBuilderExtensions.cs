using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.Data.ExtensionsMethod
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder CreateDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

            var context = serviceScope.ServiceProvider.GetRequiredService<PermisoSystemContext>();
            context.Database.Migrate();

            return app;
        }
    }
}

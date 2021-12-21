using Microsoft.EntityFrameworkCore;
using PermisoSystem.Data.Entities;
using PermisoSystem.Data.EntitiesConfiguration;
using PermisoSystem.Data.SampleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.Data.ExtensionsMethod
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder ApplyConfigurations(this ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PermisoEntityConfiguration());
            builder.ApplyConfiguration(new TipoPermisoEntityConfiguration());

            return builder;
        }

        public static ModelBuilder Seed(this ModelBuilder builder)
        {
            builder.Entity<TipoPermiso>().HasData(TipoPermisoSampleData.TipoPermisos);

            return builder;
        }
    }
}

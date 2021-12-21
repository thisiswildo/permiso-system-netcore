using Microsoft.EntityFrameworkCore;
using PermisoSystem.Data.Entities;
using PermisoSystem.Data.EntitiesConfiguration;
using PermisoSystem.Data.ExtensionsMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.Data
{
    public class PermisoSystemContext : DbContext
    {
        public PermisoSystemContext(DbContextOptions<PermisoSystemContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurations();
            builder.Seed();
        }

        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<TipoPermiso> TipoPermisos { get; set; }
    }
}

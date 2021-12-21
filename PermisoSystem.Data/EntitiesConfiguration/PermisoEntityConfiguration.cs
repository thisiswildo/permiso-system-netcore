using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.Data.EntitiesConfiguration
{
    public class PermisoEntityConfiguration : IEntityTypeConfiguration<Permiso>
    {
        public void Configure(EntityTypeBuilder<Permiso> builder)
        {
            builder.ToTable($"{nameof(Permiso)}")
                .HasKey(Permiso => Permiso.Id);
        }
    }
}

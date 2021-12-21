using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.Data.EntitiesConfiguration
{
    public class TipoPermisoEntityConfiguration : IEntityTypeConfiguration<TipoPermiso>
    {
        public void Configure(EntityTypeBuilder<TipoPermiso> builder)
        {
            builder.ToTable($"{nameof(TipoPermiso)}")
                .HasKey(tipoPermiso => tipoPermiso.Id);
        }
    }
}

using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.Data.SampleData
{
    public class TipoPermisoSampleData
    {
        public static List<TipoPermiso> TipoPermisos => new List<TipoPermiso>
        {
            new TipoPermiso { Id = 1, Descripcion = "Enfermedad" },
            new TipoPermiso { Id = 2, Descripcion = "Diligencias" },
            new TipoPermiso { Id = 3, Descripcion = "Otros" }
        };
    }
}

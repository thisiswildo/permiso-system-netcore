using PermisoSystem.Data;
using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.BL.UnitOfWork.Repositories
{
    public class TipoPermisoRepository : BaseRepository<TipoPermiso, PermisoSystemContext>
    {
        public TipoPermisoRepository(PermisoSystemContext context) : base(context) { }
    }
}

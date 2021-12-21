using PermisoSystem.Data;
using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermisoSystem.BL.UnitOfWork.Repositories
{
    public class PermisoRepository : BaseRepository<Permiso, PermisoSystemContext>
    {
        public PermisoRepository(PermisoSystemContext context) : base(context) { }
    }
}

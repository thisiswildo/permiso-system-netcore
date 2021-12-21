using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermisoSystem.BL.DTOS;
using PermisoSystem.BL.UnitOfWork.Repositories;
using PermisoSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermisoSystem.Api.Controllers
{
    [Route("api/tipos-permisos")]
    [ApiController]
    public class TipoPermisoController : BaseController<TipoPermiso, TipoPermisoDTO, TipoPermisoRepository>
    {
        public TipoPermisoController(TipoPermisoRepository repository, IMapper mapper) : base(repository, mapper) { }
    }
}

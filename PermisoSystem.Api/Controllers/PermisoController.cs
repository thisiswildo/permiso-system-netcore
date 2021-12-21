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
    [Route("api/permisos")]
    [ApiController]
    public class PermisoController : BaseController<Permiso, PermisoDTO, PermisoRepository>
    {
        public PermisoController(PermisoRepository repository, IMapper mapper) : base(repository, mapper) { }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PermisoSystem.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PermisoSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TDto, TRepository> : ControllerBase
        where TEntity : class, IEntity, new()
        where TDto : class, IEntity, new()
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;
        private readonly IMapper mapper;

        public BaseController(TRepository repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDto>>> Get()
        {
            return mapper.Map<List<TDto>>(await repository.GetAll());
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> Get(int id)
        {
            var entity = await repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return mapper.Map<TDto>(entity);
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TDto entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await repository.Update(mapper.Map<TEntity>(entity));
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TDto>> Post(TDto entity)
        {
            await repository.Add(mapper.Map<TEntity>(entity));
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TDto>> Delete(int id)
        {
            var movie = await repository.Delete(id);
            if (movie == null)
            {
                return NotFound();
            }
            return mapper.Map<TDto>(movie);
        }
    }
}

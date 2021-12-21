using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PermisoSystem.Data.Interfaces
{
    public interface IRepository<T>
        where T : class, new()
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}

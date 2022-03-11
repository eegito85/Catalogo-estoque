using CleanArchMvc.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories.Base
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        public Task<T> CreateAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<T> RemoveAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T obj)
        {
            throw new NotImplementedException();
        }
    }
}

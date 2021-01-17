using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LitLiterary.Lib.Shared.Models;
using LitLiterary.Lib.Shared.Contracts.Services;

namespace LitLiterary.Lib.Shared.Services
{
    public class Repository<T> : IRepository<Guid, T> where T: DomainObject
    {
        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(Guid id, T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

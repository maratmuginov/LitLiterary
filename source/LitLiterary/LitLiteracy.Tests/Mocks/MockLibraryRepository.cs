using LitLiterary.Lib.Shared.Contracts.Services;
using LitLiterary.Lib.Shared.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LitLiteracy.Tests.Mocks
{
    public class MockLibraryRepository : IRepository<Guid, DomainObject>
    {
        private readonly ConcurrentDictionary<Guid, DomainObject> _domainObjects = new();

        public Task<IEnumerable<DomainObject>> GetAllAsync()
        {
            return Task.FromResult(_domainObjects.Values.AsEnumerable());
        }

        public Task<DomainObject> GetAsync(Guid id)
        {
            return _domainObjects.TryGetValue(id, out var domainObject) 
                ? Task.FromResult(domainObject) 
                : null;
        }

        public Task<DomainObject> CreateAsync(DomainObject entity)
        {
            entity.Id = Guid.NewGuid();
            _domainObjects.TryAdd(entity.Id, entity);
            return Task.FromResult(entity);
        }

        public Task<DomainObject> UpdateAsync(Guid id, DomainObject entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

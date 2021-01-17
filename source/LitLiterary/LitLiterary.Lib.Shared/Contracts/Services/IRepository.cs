using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitLiterary.Lib.Shared.Contracts.Services
{
    public interface IRepository<in TPrimaryKey, TDomainObject>
    {
        Task<IEnumerable<TDomainObject>> GetAllAsync();
        Task<TDomainObject> GetAsync(TPrimaryKey id);
        Task<TDomainObject> CreateAsync(TDomainObject entity);
        Task<TDomainObject> UpdateAsync(TPrimaryKey id, TDomainObject entity);
        Task<bool> DeleteAsync(TPrimaryKey id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace LitLiterary.Lib.Shared.Contracts.Services
{
    public interface IRepository<in TPrimaryKey, TDomainObject>
    {
        Task<IEnumerable<TDomainObject>> GetAll();
        Task<TDomainObject> Get(TPrimaryKey id);
        Task<TDomainObject> Create(TDomainObject entity);
        Task<TDomainObject> Update(TPrimaryKey id, TDomainObject entity);
        Task<bool> Delete(TPrimaryKey id);
    }
}

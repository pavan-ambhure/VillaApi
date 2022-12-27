using MyVillaAPI.Models;
using System.Linq.Expressions;

namespace MyVillaAPI.Repository.IRepository
{
    public interface IVillaRepository :  IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);

    }
}

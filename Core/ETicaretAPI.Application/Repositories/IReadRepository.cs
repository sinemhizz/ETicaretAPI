using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T :BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method); //şarta uygun olan tüm verileri getirir.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method); //şarta uygun ilk veriyi getirir.
        Task<T> GetByIdAsync(string id);
    }
}

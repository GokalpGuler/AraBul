using AraBul.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Application.Repositories
{
    public interface IWriteRepository<T>: IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync (T model);
        Task<bool> AddRangeAsync (List<T> model);
        Task<bool> RemoveModelAsync (T model);
        Task<bool> RemoveRangeAsync (List<T> modelList);
        Task<bool> UpdateAsync (T model);

    }
}

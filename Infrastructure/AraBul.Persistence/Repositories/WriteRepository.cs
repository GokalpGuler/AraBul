using AraBul.Application.Repositories;
using AraBul.Domain.Entities.Common;
using AraBul.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly AraBulDbContext _dbContext;
        public WriteRepository(AraBulDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<bool> AddAsync(T model)
        {
            await Table.AddAsync(model);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> AddRangeAsync(List<T> model)
        {
            await Table.AddRangeAsync(model);

            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveByIdAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            model.IsDeleted = 1;
            Table.Update(model);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveModelAsync(T model)
        {
            model.IsDeleted = 1;
            Table.Update(model);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRangeAsync(List<T> modelList)
        {
            foreach (var item in modelList)
            {
                item.IsDeleted = 1;
            }
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(T model)
        {
            Table.Update(model);

            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}

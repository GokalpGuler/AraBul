using AraBul.Application.Repositories;
using AraBul.Domain.Entities.Common;
using AraBul.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Repositories
{
    //T ile generic yapılanmalar oluşturmuştuk. burada devam ediyoruz
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly AraBulDbContext _dbContext;
        public ReadRepository(AraBulDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(string id)
        {
            return await Table.FirstOrDefaultAsync(entity => entity.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
        {
            return await Table.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            return Table.Where(method);
        }
    }
}

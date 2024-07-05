using AraBul.Application.Repositories.IOrderRepositories;
using AraBul.Domain.Entities;
using AraBul.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Repositories.OrderRepositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(AraBulDbContext context): base(context)
        {
            
        }
    }
}

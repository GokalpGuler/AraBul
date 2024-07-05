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
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(AraBulDbContext  context) : base(context)
        {
            
        }
    }
}

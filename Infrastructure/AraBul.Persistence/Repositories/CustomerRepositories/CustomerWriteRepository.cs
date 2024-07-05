using AraBul.Application.Repositories.ICustomerRepositories;
using AraBul.Domain.Entities;
using AraBul.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Repositories.CustomerRepositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(AraBulDbContext context) : base(context)
        {
        }

    }
}

﻿using AraBul.Application.Repositories.ICustomerRepositories;
using AraBul.Domain.Entities;
using AraBul.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Repositories.CustomerRepositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(AraBulDbContext context) :base(context)
        {
            
        }
    }
}

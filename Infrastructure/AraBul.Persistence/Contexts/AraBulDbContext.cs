using AraBul.Domain.Entities;
using AraBul.Domain.Entities.Common;
using AraBul.Domain.Entities.Vehicles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Contexts
{
    public class AraBulDbContext : DbContext
    {
        public AraBulDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

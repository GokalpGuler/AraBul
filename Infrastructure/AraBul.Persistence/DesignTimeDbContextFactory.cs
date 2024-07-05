using AraBul.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AraBulDbContext>
    {
        //powershell kullanımında designtime için hazırlandı
        public AraBulDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<AraBulDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}

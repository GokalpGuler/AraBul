using AraBul.Application.Repositories;
using AraBul.Application.Repositories.ICarRepositories;
using AraBul.Domain.Entities.Vehicles;
using AraBul.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Persistence.Repositories.CarRepositories
{
    public class CarReadRepository : ReadRepository<Car>, ICarReadRepository
    {
        public CarReadRepository(AraBulDbContext context) : base(context)
        {
            
        }
    }
}

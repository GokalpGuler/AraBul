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
    public class CarWriteRepository : WriteRepository<Car>, ICarWriteRepository
    {
        public CarWriteRepository(AraBulDbContext context): base(context)
        {
            
        }
    }
}

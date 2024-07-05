using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Domain.Entities.Common
{
    public abstract class VehicleEntity : BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int EnginePower { get; set; }
        public DateTime YearOfProduct { get; set; }
    }
}

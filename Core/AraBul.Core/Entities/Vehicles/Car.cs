using AraBul.Domain.Entities.Common;
using AraBul.Domain.Enums.VehicleEnums.CarEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Domain.Entities.Vehicles
{
    public class Car : VehicleEntity
    {
        public FuelType FuelType { get; set; }
        public GearType GearType { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

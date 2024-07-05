using AraBul.Domain.Entities.Common;
using AraBul.Domain.Entities.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Domain.Entities
{
    public class Order:BaseEntity
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public int SaleName { get; set; }
        public int OrderNumber { get; set; }
        public Guid? CarId {  get; set; }
        public Car? Car { get; set; }
        public Guid CustomerId {  get; set; } 
        public Customer Customer { get; set; }

    }
}

using AraBul.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Domain.Entities
{
    public class Customer : UserEntity
    {
        public Customer()
        {
            UserType = Enums.UserType.Customer;
        }
        public ICollection<Order> Orders { get; set; }

    }
}

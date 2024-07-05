using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraBul.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            IsDeleted = 0;
        }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsDeleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class CustomerExtraServices:BaseEntity
    {
        public int CustomerID { get; set; }
        public int ExtraServicesID { get; set; }

        // Relational Properties

        public virtual Customer Customer { get; set; }
        public virtual ExtraServices ExtraServices { get; set; }
    }
}

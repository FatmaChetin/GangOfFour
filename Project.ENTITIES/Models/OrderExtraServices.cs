using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class OrderExtraService : BaseEntity
    {
        public int OrderID { get; set; }
        public int ExtraServiceID { get; set; }
        public virtual Order Order { get; set; }
        public virtual ExtraServices ExtraServices { get; set; }


    }
}

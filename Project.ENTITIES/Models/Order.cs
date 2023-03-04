using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order : BaseEntity
    {
        public Decimal ServicesFee { get; set; }
        public string ShippedAdress { get; set; }
        public int? CustomerID { get; set; }

        //Relational Properties

        public virtual Customer Customer { get; set; }
        public virtual List<OrderExtraService> OrderExtraServices { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExtraServices : BaseEntity
    {
        public string Catering { get; set; }
        public string FoodServiceWorker { get; set; }
        public string FairHostel { get; set; }
        public string StorageArea { get; set; }
        public string InvititationCard { get; set; }

        //Relational Properties

        public virtual List<OrderExtraService> OrderExtraServices { get; set; }
    }
}

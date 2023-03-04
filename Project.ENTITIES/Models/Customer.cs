using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Customer : BaseEntity
    {
        public string CompanyOfficalFirstName { get; set; }
        public string CompanyOfficialLastName { get; set; }
        public string CompanyName { get; set; }
        public string CompanySector { get; set; }


        public int? EmployeeID { get; set; }
        public int? OrderID { get; set; }


        //Relational Properties

        public virtual List<Order> Orders { get; set; }
        public virtual List<CustomerExtraServices> CustomerExtraServices { get; set; }
    }
}

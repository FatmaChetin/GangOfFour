using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? EmployeeDepartmentID { get; set; }
        public virtual EmployeelDepertmant EmployeelDepertmant { get; set; }
        public virtual List<Customer> Customers { get; set; }
        public virtual OrganizationCompany OrganizationCompany { get; set; }
    }
}

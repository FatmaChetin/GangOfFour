using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class OrganizationCompany : BaseEntity
    {
        public string ContactNumber { get; set; }
        public int? EmployeeID { get; set; }

        public virtual List<Employee> Employees { get; set; }


    }
}

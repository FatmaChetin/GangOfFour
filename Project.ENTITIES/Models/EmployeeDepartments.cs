using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class EmployeelDepartmant : BaseEntity
    {
        public string DepartmentName { get; set; }
        public string OrganizationCompanyID { get; set; }


        public virtual List<Employee> Employeese { get; set; }
    }
}

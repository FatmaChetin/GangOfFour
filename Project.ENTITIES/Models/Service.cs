using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class Service : BaseEntity
    {
        public string Area { get; set; }
        public string ModulerStand { get; set; }
        public string CustomStand { get; set; }
        public virtual List<ServiceProblem> Problems { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ServiceProblem : BaseEntity
    {
        public int? ServiceID { get; set; }
        public int? PossibleProblemID { get; set; }
        public virtual Service Service { get; set; }
        public virtual PossibleProblems Problems { get; set; }
    }
}

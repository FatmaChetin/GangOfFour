using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PossibleProblems : BaseEntity
    {
        public string ProblemsRelatedToTheServicesProvided { get; set; }
        public string ProblemsRelatedToTheFairArea { get; set; }
        public string Description { get; set; }
        public virtual List<ServiceProblem> Problems { get; set; }
    }
}

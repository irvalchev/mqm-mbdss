using Mqm.Mbdss.Core.DomainTheory;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class Situation
    {
        #region Properties

        public ICollection<Process> Processes { get; set; }
        public ICollection<QuantityAssignment> QuantityAssertions { get; set; }
        public ICollection<ExistenceAssignment> StructuralAssertions { get; set; }

        public IEnumerable<ObjectInstance> Objects
        {
            get
            {
                return StructuralAssertions?.Where(a => a.Element is ObjectInstance).Cast<ObjectInstance>();
            }
        }

        public IEnumerable<ObjectRelation> ObjectRelations
        {
            get
            {
                return StructuralAssertions?.Where(a => a.Element is ObjectRelation).Cast<ObjectRelation>();
            }
        }

        public DomainValue GetQuantityRoleValue(IWithQuantityRoles owner, QuantityRole role)
        {
            return QuantityAssertions?.SingleOrDefault(a => a.Owner == owner && a.QuantityRole == role)?.Value;
        }
        #endregion Properties
    }
}
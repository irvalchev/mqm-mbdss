using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class Condition
    {
        #region Properties

        public CompositionType CompositionType { get; set; }

        public ICollection<Condition> CompoundConditions { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public ICollection<QuantityRoleConstraint> QuantityConditions { get; set; }

        public ICollection<ExistenceAssignment> StructuralConditions { get; set; }

        #endregion Properties
    }
}
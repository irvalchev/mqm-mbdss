using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class Condition
    {
        #region Properties

        public CompositionType CompositionType { get; set; }

        public IList<Condition> CompoundConditions { get; set; }

        public int Id { get; set; }

        public string Description { get; set; }

        public IList<QuantityRoleConstraint> QuantityConditions { get; set; }

        public IList<ExistenceAssignment> StructuralConditions { get; set; }

        #endregion Properties
    }
}
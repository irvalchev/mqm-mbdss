using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class QuantityRoleConstraint
    {
        #region Properties

        public ConstraintType Constraint { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public IDictionary<int, QuantityRoleMapping> QuantityAssignments { get; set; }
        public IDictionary<int, DomainValue> ValueAssignments { get; set; }

        #endregion Properties
    }
}
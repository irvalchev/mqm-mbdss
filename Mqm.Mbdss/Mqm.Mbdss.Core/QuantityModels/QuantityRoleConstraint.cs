using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class QuantityRoleConstraint
    {
        #region Properties

        public ConstraintType Constraint { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public Dictionary<int, QuantityRoleMapping> QuantityAssignments { get; set; }
        public Dictionary<int, DomainValue> ValueAssignments { get; set; }

        #endregion Properties
    }
}
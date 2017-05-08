using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ConstraintTuple
    {
        #region Properties

        public ConstraintType Constraint { get; set; }
        public IList<DomainValue> Values { get; set; }

        #endregion Properties
    }
}
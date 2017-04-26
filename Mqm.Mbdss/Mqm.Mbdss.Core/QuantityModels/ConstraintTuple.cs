using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class ConstraintTuple
    {
        #region Properties

        public ConstraintType Constraint { get; set; }
        public IList<DomainValue> Values { get; set; }

        #endregion Properties
    }
}
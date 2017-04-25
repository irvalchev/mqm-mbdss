using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class CompoundCondition : Condition
    {
        #region Properties

        public IList<Condition> SubConditions { get; set; }
        public CompositionType Type { get; set; }

        #endregion Properties
    }
}
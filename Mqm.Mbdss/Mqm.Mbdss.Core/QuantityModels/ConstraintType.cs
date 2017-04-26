using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class ConstraintType
    {
        #region Properties

        public IList<ConstraintTuple> AllowedTuples { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Domain> Signature { get; set; }

        #endregion Properties
    }
}
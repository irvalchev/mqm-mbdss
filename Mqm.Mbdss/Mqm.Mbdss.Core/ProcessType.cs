using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class ProcessType
    {
        #region Properties

        public Effect Effect { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Condition Precondition { get; set; }
        public IList<ObjectRole> Roles { get; set; }

        #endregion Properties
    }
}
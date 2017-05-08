using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class Influence
    {
        #region Properties

        public int Description { get; set; }
        public int Id { get; set; }
        public IList<QuantityRoleMapping> QuantityAssignments { get; set; }
        public QuantityRoleMapping QuantityDefinition { get; set; }
        public InfluenceType Type { get; set; }

        #endregion Properties
    }
}
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class RelationType
    {
        #region Properties

        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ObjectType> Signature { get; set; }

        #endregion Properties
    }
}
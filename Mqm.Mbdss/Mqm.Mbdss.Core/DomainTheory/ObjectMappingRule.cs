using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ObjectMappingRule
    {
        #region Properties

        public Condition Condition { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ObjectRole> Roles { get; set; }
        public ICollection<ObjectRole> UniqueObjectRoles { get; set; }

        #endregion Properties
    }
}
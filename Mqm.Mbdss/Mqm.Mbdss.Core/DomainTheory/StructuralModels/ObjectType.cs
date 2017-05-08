using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ObjectType
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ObjectType> ParentTypes { get; set; }
        public ICollection<QuantityRole> QuantityRoles { get; set; }

        #endregion Properties
    }
}
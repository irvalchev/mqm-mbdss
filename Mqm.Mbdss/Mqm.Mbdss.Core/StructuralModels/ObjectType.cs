using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class ObjectType
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ObjectType> ParentTypes { get; set; }
        public IList<QuantityRole> QuantityRoles { get; set; }

        #endregion Properties
    }
}
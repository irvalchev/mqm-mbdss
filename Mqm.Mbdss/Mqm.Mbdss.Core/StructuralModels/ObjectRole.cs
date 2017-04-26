using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class ObjectRole
    {
        #region Properties

        public IList<ObjectType> AllowedTypes { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        #endregion Properties
    }
}
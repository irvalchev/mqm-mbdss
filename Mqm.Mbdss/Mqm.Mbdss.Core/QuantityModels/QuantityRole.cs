using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class QuantityRole : IStructuralElement
    {
        #region Properties

        public Domain Domain { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ObjectType> ObjectTypes { get; set; }

        #endregion Properties
    }
}
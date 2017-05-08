using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class QuantityRole : IStructuralElementDefinition
    {
        #region Properties

        public Domain Domain { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ObjectType> ObjectTypes { get; set; }

        #endregion Properties
    }
}
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ObjectRoleRelation : IStructuralElementDefinition
    {
        #region Properties

        public int Id { get; set; }
        public IList<ObjectRole> ObjectRoles { get; set; }
        public RelationType Relation { get; set; }

        #endregion Properties
    }
}
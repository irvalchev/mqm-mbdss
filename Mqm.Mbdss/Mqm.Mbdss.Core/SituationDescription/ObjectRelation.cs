using Mqm.Mbdss.Core.DomainTheory;
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class ObjectRelation : IStructuralElement
    {
        #region Properties

        public int Id { get; set; }
        public IList<ObjectInstance> Objects{ get; set; }
        public RelationType Relation { get; set; }

        #endregion Properties
    }
}
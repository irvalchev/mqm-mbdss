using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class Effect
    {
        #region Properties

        public int Id { get; set; }

        public ICollection<Influence> InfluenceEffects { get; set; }

        public ICollection<QuantityRoleConstraint> QuantityEffects { get; set; }

        public ICollection<ExistenceAssignment> StructuralEffects { get; set; }

        #endregion Properties
    }
}
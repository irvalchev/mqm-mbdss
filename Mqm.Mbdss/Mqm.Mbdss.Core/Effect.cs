using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class Effect
    {
        #region Properties

        public int Id { get; set; }

        public IList<Influence> InfluenceEffects { get; set; }

        public IList<QuantityRoleConstraint> QuantityEffects { get; set; }

        public IList<ExistenceAssignment> StructuralEffects { get; set; }

        #endregion Properties
    }
}
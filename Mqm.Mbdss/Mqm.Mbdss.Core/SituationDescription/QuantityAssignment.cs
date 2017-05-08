using Mqm.Mbdss.Core.DomainTheory;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class QuantityAssignment
    {
        #region Properties

        public IWithQuantityRoles Owner { get; set; }
        public QuantityRole QuantityRole { get; set; }
        public DomainValue Value { get; set; }

        #endregion Properties
    }
}
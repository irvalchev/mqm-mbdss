using Mqm.Mbdss.Core.DomainTheory;
using System;
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class ObjectInstance:IStructuralElement, IWithQuantityRoles
    {
        #region Properties

        public Guid Uid { get; set; }
        public ObjectType Type { get; set; }
        public ICollection<QuantityRole> QuantityRoles
        {
            get
            {
                return Type?.QuantityRoles;
            }
        }

        #endregion Properties
    }
}
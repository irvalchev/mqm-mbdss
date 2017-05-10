using Mqm.Mbdss.Core.DomainTheory;
using System;
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class ObjectInstance : IStructuralElement, IWithQuantityRoles, IEquatable<ObjectInstance>
    {
        #region Properties

        public ICollection<QuantityRole> QuantityRoles
        {
            get
            {
                return Type?.QuantityRoles;
            }
        }

        public ObjectType Type { get; set; }
        public Guid Uid { get; set; }

        #endregion Properties

        #region Methods

        #region Equality Comparison

        public bool Equals(ObjectInstance other)
        {
            return other != null && other.Uid == this.Uid;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ObjectInstance);
        }

        public override int GetHashCode()
        {
            return this.Uid.GetHashCode();
        }

        #endregion Equality Comparison

        #endregion Methods
    }
}
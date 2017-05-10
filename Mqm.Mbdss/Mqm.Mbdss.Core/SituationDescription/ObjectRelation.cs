using Mqm.Mbdss.Core.DomainTheory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class ObjectRelation : IStructuralElement, IEquatable<ObjectRelation>
    {
        #region Properties

        public IList<ObjectInstance> Objects{ get; set; }
        public RelationType Relation { get; set; }

        #endregion Properties

        #region Methods

        #region Equality Comparison

        public bool Equals(ObjectRelation other)
        {
            return other != null
                && other.Relation?.Id == this.Relation?.Id
                && other.Objects?.Count == this.Objects?.Count;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ObjectRelation);
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 47;
                hash = hash * 29 + Relation?.GetHashCode() ?? 0;
                foreach (ObjectInstance obj in Objects)
                {
                    hash = hash * 29 + obj.GetHashCode();
                }
                return hash;
            }
        }

        #endregion Equality Comparison

        #endregion Methods
    }
}
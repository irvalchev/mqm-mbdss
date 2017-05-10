using System;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ObjectType : IEquatable<ObjectType>
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ObjectType> ParentTypes { get; set; }
        public ICollection<QuantityRole> QuantityRoles { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Checks if the current type is a subtype of another object type
        /// </summary>
        /// <param name="parentType">The parent type to check for</param>
        /// <returns></returns>
        public bool IsSubtypeOf(ObjectType parentType)
        {
            return ParentTypes != null && (ParentTypes.Contains(parentType) || ParentTypes.Any(t => t.IsSubtypeOf(parentType)));
        }

        #region Equality Comparison

        public bool Equals(ObjectType other)
        {
            return other != null && other.Id == this.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ObjectType);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        #endregion Equality Comparison

        #endregion Methods
    }
}
using System;
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ObjectRole : IStructuralElementDefinition, IEquatable<ObjectRole>
    {
        #region Properties

        public ICollection<ObjectType> AllowedTypes { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        #endregion Properties

        #region Methods

        #region Equality Comparison

        public bool Equals(ObjectRole other)
        {
            return other != null && other.Id == this.Id
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ObjectRole);
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        #endregion Equality Comparison

        #endregion Methods
    }
}
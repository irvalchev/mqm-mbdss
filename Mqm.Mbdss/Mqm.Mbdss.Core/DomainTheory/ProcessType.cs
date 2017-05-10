using System;
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ProcessType: IEquatable<ProcessType>
    {
        #region Properties

        public string Description { get; set; }
        public Effect Effect { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ObjectRole> ObjectRoles { get; set; }
        public Condition Precondition { get; set; }
        public ICollection<QuantityRole> ProcessQuantityRoles { get; set; }

        #endregion Properties

        #region Methods
        #region Equality Comparison

        public bool Equals(ProcessType other)
        {
            return other != null && other.Id == this.Id;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ProcessType);
        }

        public override int GetHashCode()
        {
            return Id;
        }

        #endregion Equality Comparison
        #endregion
    }
}
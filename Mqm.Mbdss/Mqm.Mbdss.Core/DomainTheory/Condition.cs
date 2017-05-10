using Mqm.Mbdss.Core.SituationDescription;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class Condition
    {
        #region Properties

        public CompositionType CompositionType { get; set; }

        public ICollection<Condition> CompoundConditions { get; set; }

        public string Description { get; set; }
        public int Id { get; set; }
        public ICollection<QuantityRoleConstraint> QuantityConditions { get; set; }

        public ICollection<ExistenceAssignment> StructuralConditions { get; set; }

        /// <summary>
        /// Gets all possible role assignments which correspond to the current condition specification
        /// </summary>
        /// <param name="objects">The objects that can be used in the mapping</param>
        /// <param name="relations">The object relations that can be used in the mapping</param>
        /// <returns>
        /// A collection of possible mappings. Each item in the collection represents a possible
        /// mapping of object roles to object instances, which satisfy the conditions
        /// </returns>
        public ICollection<ProcessRolesMap> GetPossibleRoleMaps(List<ObjectInstance> objects, List<ObjectRelation> relations)
        {
            throw new NotImplementedException();
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Returns all object roles that are used in the condition.
        /// NB: The function takes in consideration only the structural conditions. The presumption
        ///     is that each object role in a quantity condition should have an existence assignment
        ///     in a structural condition
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ObjectRole> GetAllRelevantObjectRoles()
        {
            IEnumerable<ObjectRole> roles = StructuralConditions?.Where(c => c.Element is ObjectRole)
                .Select(c => c.Element).Cast<ObjectRole>() ?? new List<ObjectRole>();

            if (CompoundConditions != null)
            {
                foreach (Condition cond in CompoundConditions)
                {
                    roles = roles.Union(cond.GetAllRelevantObjectRoles());
                }
            }

            return roles.Distinct();
        }

        #endregion Methods
    }
}
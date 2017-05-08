using Mqm.Mbdss.Core.DomainTheory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class Process : IWithQuantityRoles
    {
        #region Constructors

        public Process(ProcessType type)
        {
            Uid = Guid.NewGuid();
            Type = type;
        }

        #endregion Constructors

        #region Properties

        public ICollection<ObjectRole> ObjectRoles
        {
            get
            {
                return Type?.ObjectRoles;
            }
        }

        public IDictionary<ObjectRole, ObjectInstance> ObjectRolesMap { get; set; }

        public ICollection<ObjectInstance> Objects
        {
            get
            {
                return ObjectRolesMap?.Values;
            }
        }

        public ICollection<QuantityRole> QuantityRoles
        {
            get
            {
                return Type?.ProcessQuantityRoles;
            }
        }

        public ProcessType Type { get; set; }

        public Guid Uid { get; set; }

        #endregion Properties

        /// <summary>
        /// Creates (or finds the current existing) structural effects of the process
        /// NB: The function will automatically add the new objects in the process' <see cref="ObjectRolesMap"/>
        /// NB: The passed situation description will be updated with the newly created objects
        /// </summary>
        /// <param name="situation">
        /// The current situation description with all objects and object relations information. It
        /// will be updated with the structural effects from the found effects
        /// </param>
        /// <param name="mappingRules">A collection of all objects mapping rules from the domain theory</param>
        /// <returns>A collection of the NEW effect elements</returns>
        public ICollection<IStructuralElement> CreateEffectElements(Situation situation, ICollection<ObjectMappingRule> mappingRules)
        {
            List<ObjectRelation> situationObjectRelations = situation.ObjectRelations.ToList();
            List<ObjectInstance> situationObjects = situation.Objects.ToList();
            List<IStructuralElement> effectElements = new List<IStructuralElement>();

            throw new NotImplementedException();

            return effectElements;
        }
    }
}
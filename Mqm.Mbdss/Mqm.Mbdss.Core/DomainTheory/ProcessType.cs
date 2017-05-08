using Mqm.Mbdss.Core.SituationDescription;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class ProcessType
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

        /// <summary>
        /// Generates all processes of the current process type in the provided situation.
        /// NB: New processes and structural elements will be added in the passed <see cref="situation"/>.
        /// </summary>
        /// <param name="situation">
        /// The current situation description with all objects and object relations information. It
        /// will be updated with the found processes and structural elements.
        /// </param>
        /// <param name="mappingRules">A collection of all objects mapping rules from the domain theory</param>
        /// <returns>A collection of the found NEW processes of this type</returns>
        public ICollection<Process> GenerateProcesses(Situation situation, ICollection<ObjectMappingRule> mappingRules)
        {
            List<Process> newProcesses = new List<Process>();
            List<ObjectRelation> situationObjectRelations = situation.ObjectRelations.ToList();
            List<ObjectInstance> situationObjects = situation.Objects.ToList();

            throw new NotImplementedException();
            return newProcesses;
        }

        #endregion Methods
    }
}
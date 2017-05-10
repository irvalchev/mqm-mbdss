using Mqm.Mbdss.Core.DomainTheory;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class Situation
    {
        #region Properties

        public ICollection<Process> Processes { get; set; }
        public ICollection<QuantityAssignment> QuantityAssertions { get; set; }
        public ICollection<ExistenceAssignment> StructuralAssertions { get; set; }

        public IEnumerable<ObjectInstance> Objects
        {
            get
            {
                return StructuralAssertions?.Where(a => a.Element is ObjectInstance).Cast<ObjectInstance>();
            }
        }

        public IEnumerable<ObjectRelation> ObjectRelations
        {
            get
            {
                return StructuralAssertions?.Where(a => a.Element is ObjectRelation).Cast<ObjectRelation>();
            }
        }

        public DomainValue GetQuantityRoleValue(IWithQuantityRoles owner, QuantityRole role)
        {
            return QuantityAssertions?.SingleOrDefault(a => a.Owner == owner && a.QuantityRole == role)?.Value;
        }

        #endregion Properties

        /// <summary>
        /// Finds and creates all processes of a process type in the current situation. The function
        /// will generate the found processes and add the relevant elements in the situation description.
        /// </summary>
        /// <param name="processType">
        /// The process type of which new processes will be searched in the situation
        /// </param>
        /// <param name="mappingRules">
        /// A collection of all objects mapping rules from the domain theory
        /// </param>
        /// <returns>A collection of the found NEW processes of this type</returns>
        public ICollection<Process> CreateProcesses(ProcessType processType, ICollection<ObjectMappingRule> mappingRules)
        {
            List<Process> newProcesses = new List<Process>();
            List<ObjectRelation> situationObjectRelations = ObjectRelations.Distinct().ToList();
            List<ObjectInstance> situationObjects = Objects.Distinct().ToList();
            // Each item in the collection can be used as a base for a new process.
            ICollection<ProcessRolesMap> possibleProcessRoleMaps = processType.Precondition.GetPossibleRoleMaps(situationObjects, situationObjectRelations);

            foreach (ProcessRolesMap rolesMap in possibleProcessRoleMaps)
            {
                var newProcess = new Process(processType, rolesMap);

                // Add the process in the situation if not already existing
                if (this.Processes.All(pr => !pr.IsSameAs(newProcess)))
                {
                    this.Processes.Add(newProcess);
                    // Creating the process effect elements and adding them in the process and the
                    // situation descriptions
                    CreateEffectElements(newProcess, mappingRules);

                    newProcesses.Add(newProcess);
                }
            }

            return newProcesses;
        }

        /// <summary>
        /// Creates (or finds the current existing) structural effects of a process
        /// NB: The function will add the new objects in the process' <see cref="ObjectRolesMap"/>
        /// NB: The situation description will be updated with the newly created elements
        /// </summary>
        /// <param name="process">
        /// The process for which to create the effect elements
        /// </param>
        /// <param name="mappingRules">A collection of all objects mapping rules from the domain theory</param>
        /// <returns>A collection of NEW effect elements</returns>
        public ICollection<IStructuralElement> CreateEffectElements(Process process, ICollection<ObjectMappingRule> mappingRules)
        {
            List<ObjectRelation> situationObjectRelations = this.ObjectRelations.ToList();
            List<ObjectInstance> situationObjects = this.Objects.ToList();
            List<IStructuralElement> effectElements = new List<IStructuralElement>();

            throw new NotImplementedException();

            return effectElements;
        }

        /// <summary>
        /// Performs a forward completion on the situation by finding all relevant processes and generating the effect elements (recursively)
        /// </summary>
        /// <param name="domainTheory">
        /// The relevant domain theory containing all relevant information to find and create the processes in the situation
        /// </param>
        /// <returns>A collection of the added new processes</returns>
        public ICollection<Process> ForwardCompletion(DomainTheory.DomainTheory domainTheory)
        {
            IEnumerable<Process> newProcesses = new List<Process>();
            IEnumerable<Process> newProcessesInIteration;

            do
            {
                newProcessesInIteration = new List<Process>();
                // Find and create the new processes for each process type
                foreach (ProcessType procType in domainTheory.ProcessTypes)
                {
                    newProcessesInIteration = newProcessesInIteration.Union(CreateProcesses(procType, domainTheory.ObjectMappingRules));
                }
                newProcesses = newProcesses.Union(newProcessesInIteration);
            } // Perform until there are no more processes to be created
            while (newProcessesInIteration.Any());

            return newProcesses.ToList();
        }
    }
}
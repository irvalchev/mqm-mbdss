using Mqm.Mbdss.Core.DomainTheory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mqm.Mbdss.Core.SituationDescription
{
    public class Process : IWithQuantityRoles
    {
        #region Constructors

        public Process(ProcessType type, ProcessRolesMap objectRolesMap)
        {
            Uid = Guid.NewGuid();
            ObjectRolesMap = objectRolesMap ?? throw new ArgumentNullException(nameof(objectRolesMap));
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// All object roles in the process (based on its type)
        /// </summary>
        public ICollection<ObjectRole> ObjectRoles
        {
            get
            {
                return Type?.ObjectRoles;
            }
        }

        /// <summary>
        /// Contains the known connection between roles and object instances
        /// </summary>
        public ProcessRolesMap ObjectRolesMap { get; private set; }

        /// <summary>
        /// All currently assigned object in roles.
        /// NB: This is extracted from the <see cref="ObjectRolesMap"/>, so there might be duplicates
        /// </summary>
        public ICollection<ObjectInstance> Objects
        {
            get
            {
                return ObjectRolesMap?.Values;
            }
        }

        /// <summary>
        /// All quantity roles of the process itself (based on its type)
        /// </summary>
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

        #region Methods

        /// <summary>
        /// Checks if the current process is the same as another process.
        /// NB: As a basis for the comparison are used the assigned objects in the object roles which
        ///     are specified in the CONDITION
        /// </summary>
        /// <param name="anotherProcess">The process to compare with</param>
        /// <returns></returns>
        public bool IsSameAs(Process anotherProcess)
        {
            if (anotherProcess == null || !anotherProcess.Type.Equals(this.Type))
            {
                return false;
            }
            else if (anotherProcess == this || anotherProcess.Uid == this.Uid)
            {
                return true;
            }
            else
            {
                List<ObjectRole> conditionRoles = this.Type.Precondition.GetAllRelevantObjectRoles().ToList();

                foreach (var role in conditionRoles)
                {
                    ObjectInstance obj1 = this.ObjectRolesMap[role];
                    ObjectInstance obj2 = anotherProcess.ObjectRolesMap[role];

                    // When any objects in the same roles are not the same and not equal then return false
                    if (obj1 != obj2 && (!obj1?.Equals(obj2) ?? true))
                    {
                        return false;
                    }
                }

                // If all object in the roles are the same then return true
                return true;
            }
        }

        #endregion Methods
    }
}
using System;
using System.Collections.Generic;

namespace Mqm.Mbdss.Core.DomainTheory
{
    public class DomainTheory
    {
        #region Properties

        public ICollection<ProcessType> ProcessTypes { get; set; }
        public ICollection<ObjectMappingRule> ObjectMappingRules{ get; set; }

        #endregion Properties
    }
}
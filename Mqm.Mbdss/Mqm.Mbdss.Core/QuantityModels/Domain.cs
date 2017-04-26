﻿using System.Collections.Generic;

namespace Mqm.Mbdss.Core
{
    public class Domain
    {
        #region Properties

        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<DomainValue> Values { get; set; }

        #endregion Properties
    }
}
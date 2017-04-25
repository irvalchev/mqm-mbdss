using System;
using System.Collections.Generic;
using System.Text;

namespace Mqm.Mbdss.Core
{
    public abstract class Condition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}

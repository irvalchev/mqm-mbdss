using System;
using System.Collections.Generic;
using System.Text;

namespace Mqm.Mbdss.Core
{
    public class ObjectType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ObjectType> ParentTypes{ get; set; }
    }
}

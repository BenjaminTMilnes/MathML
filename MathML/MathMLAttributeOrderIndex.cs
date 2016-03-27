using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MathMLAttributeOrderIndex : Attribute
    {
        public int OrderIndex { get; private set; }

        public MathMLAttributeOrderIndex(int orderIndex)
        {
            OrderIndex = orderIndex;
        }
    }
}

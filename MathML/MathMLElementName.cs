using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MathMLElementName : Attribute
    {
        public string ElementName { get; private set; }

        public MathMLElementName(string elementName)
        {
            ElementName = elementName;
        }
    }
}
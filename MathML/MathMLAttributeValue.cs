using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [AttributeUsage(AttributeTargets.Field)]
    public class MathMLAttributeValue : Attribute
    {
        public string Value { get; private set; }

        public MathMLAttributeValue(string value)
        {
            Value = value;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MathMLAttributeName : Attribute
    {
        public string AttributeName { get; private set; }

        public MathMLAttributeName(string attributeName)
        {
            AttributeName = attributeName;
        }
    }
}

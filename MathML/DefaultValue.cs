using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultValue : Attribute
    {
        public object Value { get; private set; }

        public DefaultValue(object value)
        {
            Value = value;
        }
    }
}

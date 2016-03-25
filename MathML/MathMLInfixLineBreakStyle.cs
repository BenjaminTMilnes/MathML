using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLInfixLineBreakStyle
    {
        [MathMLAttributeValue("before")]
        Before = 0,

        [MathMLAttributeValue("after")]
        After = 1,

        [MathMLAttributeValue("duplicate")]
        Duplicate = 2
    }
}

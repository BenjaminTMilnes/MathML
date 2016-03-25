using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLOperatorForm
    {
        [MathMLAttributeValue("prefix")]
        Prefix = 0,

        [MathMLAttributeValue("infix")]
        Infix = 1,

        [MathMLAttributeValue("postfix")]
        Postfix = 2
    }
}

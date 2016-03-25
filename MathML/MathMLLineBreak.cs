using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLLineBreak
    {
        [MathMLAttributeValue("auto")]
        Auto = 0,

        [MathMLAttributeValue("newline")]
        NewLine = 1,

        [MathMLAttributeValue("nobreak")]
        NoBreak = 2,

        [MathMLAttributeValue("goodbreak")]
        GoodBreak = 3,

        [MathMLAttributeValue("badbreak")]
        BadBreak = 4
    }
}

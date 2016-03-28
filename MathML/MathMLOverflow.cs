using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLOverflow
    {
        [MathMLAttributeValue("linebreak")]
        LineBreak = 0,

        [MathMLAttributeValue("scroll")]
        Scroll = 1,

        [MathMLAttributeValue("elide")]
        Elide = 2,

        [MathMLAttributeValue("truncate")]
        Truncate = 3,

        [MathMLAttributeValue("scale")]
        Scale = 4
    }
}

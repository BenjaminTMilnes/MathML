using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLMeasuredLengthUnit
    {
        [MathMLAttributeValue("em")]
        Em = 0,

        [MathMLAttributeValue("ex")]
        Ex = 1,

        [MathMLAttributeValue("px")]
        Pixels = 2,

        [MathMLAttributeValue("in")]
        Inches = 3,

        [MathMLAttributeValue("cm")]
        Centimeters = 4,

        [MathMLAttributeValue("mm")]
        Millimeters = 5,

        [MathMLAttributeValue("pt")]
        Points = 6,

        [MathMLAttributeValue("pc")]
        Picas = 7,

        [MathMLAttributeValue("%")]
        Percent = 8
    }
}
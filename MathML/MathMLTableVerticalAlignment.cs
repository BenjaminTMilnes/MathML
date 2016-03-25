using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLTableVerticalAlignment
    {
        [MathMLAttributeValue("axis")]
        Axis = 0,

        [MathMLAttributeValue("baseline")]
        Baseline = 1,

        [MathMLAttributeValue("bottom")]
        Bottom = 2,

        [MathMLAttributeValue("center")]
        Center = 3,

        [MathMLAttributeValue("top")]
        Top = 4
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLLabeledTableRowPlacement
    {
        [MathMLAttributeValue("left")]
        Left = 0,

        [MathMLAttributeValue("right")]
        Right = 1,

        [MathMLAttributeValue("leftoverlap")]
        LeftOverlap = 2,

        [MathMLAttributeValue("rightoverlap")]
        RightOverlap = 3
    }
}

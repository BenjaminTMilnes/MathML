using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLUnderOverAlignment
    {
        [MathMLAttributeValue("left")]
        Left = 0,

        [MathMLAttributeValue("center")]
        Center = 1,

        [MathMLAttributeValue("right")]
        Right = 2
    }
}

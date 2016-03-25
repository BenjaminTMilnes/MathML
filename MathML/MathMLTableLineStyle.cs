using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLTableLineStyle
    {
        [MathMLAttributeValue("none")]
        None = 0,

        [MathMLAttributeValue("solid")]
        Solid = 1,

        [MathMLAttributeValue("dashed")]
        Dashed = 2
    }
}

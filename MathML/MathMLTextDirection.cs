using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLTextDirection
    {
        [MathMLAttributeValue("ltr")]
        LeftToRight = 0,

        [MathMLAttributeValue("rtl")]
        RightToLeft = 1
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLOverflow
    {
        LineBreak = 0,
        Scroll = 1,
        Elide = 2,
        Truncate = 3,
        Scale = 4
    }
}

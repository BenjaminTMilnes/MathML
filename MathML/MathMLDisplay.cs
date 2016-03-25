using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLDisplay
    {
        [MathMLAttributeValue("block")]
        Block = 0,

        [MathMLAttributeValue("inline")]
        Inline = 1
    }
}

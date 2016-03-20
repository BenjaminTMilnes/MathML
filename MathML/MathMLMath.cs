using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("math")]
    public class MathMLMath : MathMLElement
    {
        [MathMLAttributeName("display")]
        public MathMLDisplay Display { get; set; }

        [MathMLAttributeName("overflow")]
        public MathMLOverflow Overflow { get; set; }
    }
}

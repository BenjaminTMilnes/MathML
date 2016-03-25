using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("munderover")]
    public class MathMLUnderOver : MathMLElement
    {
        [MathMLAttributeName("accent")]
        public bool AccentOver { get; set; }

        [MathMLAttributeName("accentunder")]
        public bool AccentUnder { get; set; }

        [MathMLAttributeName("align")]
        public MathMLUnderOverAlignment Alignment { get; set; }
    }
}

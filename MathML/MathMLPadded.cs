using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mpadded")]
    public class MathMLPadded : MathMLElement
    {
        [MathMLAttributeName("depth")]
        public MathMLLength Depth { get; set; }

        [MathMLAttributeName("height")]
        public MathMLLength Height { get; set; }

        [MathMLAttributeName("width")]
        public MathMLLength Width { get; set; }

        [MathMLAttributeName("lspace")]
        public MathMLLength LeftSpace { get; set; }

        [MathMLAttributeName("voffset")]
        public MathMLLength VerticalOffset { get; set; }
    }
}

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
        [MathMLAttributeName("width")]
        [MathMLAttributeOrderIndex(7)]
        public MathMLLength Width { get; set; }

        [MathMLAttributeName("height")]
        [MathMLAttributeOrderIndex(8)]
        public MathMLLength Height { get; set; }

        [MathMLAttributeName("depth")]
        [MathMLAttributeOrderIndex(9)]
        public MathMLLength Depth { get; set; }

        [MathMLAttributeName("lspace")]
        [MathMLAttributeOrderIndex(10)]
        public MathMLLength LeftSpace { get; set; }

        [MathMLAttributeName("voffset")]
        [MathMLAttributeOrderIndex(11)]
        public MathMLLength VerticalOffset { get; set; }
    }
}

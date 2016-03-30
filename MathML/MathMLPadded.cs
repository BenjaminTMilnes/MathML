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
        public MathMLMeasuredLength Width { get; set; }

        [MathMLAttributeName("height")]
        [MathMLAttributeOrderIndex(8)]
        public MathMLMeasuredLength Height { get; set; }

        [MathMLAttributeName("depth")]
        [MathMLAttributeOrderIndex(9)]
        public MathMLMeasuredLength Depth { get; set; }

        [MathMLAttributeName("lspace")]
        [MathMLAttributeOrderIndex(10)]
        public MathMLMeasuredLength LeftSpace { get; set; }

        [MathMLAttributeName("voffset")]
        [MathMLAttributeOrderIndex(11)]
        public MathMLMeasuredLength VerticalOffset { get; set; }
    }
}

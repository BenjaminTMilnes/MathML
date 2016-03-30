using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mspace")]
    public class MathMLSpace : MathMLElement
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

        [MathMLAttributeName("linebreak")]
        [MathMLAttributeOrderIndex(10)]
        [DefaultValue(MathMLLineBreak.Auto)]
        public MathMLLineBreak LineBreak { get; set; }

        public MathMLSpace()
        {
            LineBreak = MathMLLineBreak.Auto;
        }
    }
}

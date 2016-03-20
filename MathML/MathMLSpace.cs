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
        [MathMLAttributeName("depth")]
        public MathMLLength Depth { get; set; }

        [MathMLAttributeName("height")]
        public MathMLLength Height { get; set; }

        [MathMLAttributeName("width")]
        public MathMLLength Width { get; set; }

        [MathMLAttributeName("linebreak")]
        public MathMLLineBreak LineBreak { get; set; }
    }
}

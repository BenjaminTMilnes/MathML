using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mglyph")]
    public class MathMLGlyph : MathMLElement
    {
        [MathMLAttributeName("alt")]
        public string AlternativeText { get; set; }

        [MathMLAttributeName("height")]
        public MathMLLength Height { get; set; }

        [MathMLAttributeName("src")]
        public string Source { get; set; }

        [MathMLAttributeName("valign")]
        public MathMLLength VerticalAlignment { get; set; }

        [MathMLAttributeName("width")]
        public MathMLLength Width { get; set; }
    }
}
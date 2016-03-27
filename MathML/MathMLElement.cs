using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public abstract class MathMLElement
    {
        [MathMLAttributeName("id")]
        [MathMLAttributeOrderIndex(1)]
        public string Id { get; set; }

        [MathMLAttributeName("class")]
        [MathMLAttributeOrderIndex(2)]
        public string StyleClass { get; set; }

        [MathMLAttributeName("style")]
        [MathMLAttributeOrderIndex(3)]
        public string Style { get; set; }

        [MathMLAttributeName("href")]
        [MathMLAttributeOrderIndex(4)]
        public string HRef { get; set; }

        [MathMLAttributeName("mathbackground")]
        [MathMLAttributeOrderIndex(5)]
        public MathMLColor MathBackgroundColor { get; set; }

        [MathMLAttributeName("mathcolor")]
        [MathMLAttributeOrderIndex(6)]
        public MathMLColor MathColor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mo")]
    public class MathMLOperator : MathMLElement
    {
        [MathMLAttributeName("accent")]
        public bool Accent { get; set; }

        [MathMLAttributeName("fence")]
        public bool Fence { get; set; }

        [MathMLAttributeName("form")]
        public MathMLOperatorForm Form { get; set; }

        [MathMLAttributeName("largeop")]
        public bool LargeOperator { get; set; }

        [MathMLAttributeName("movablelimits")]
        public bool MovableLimits { get; set; }

        [MathMLAttributeName("separator")]
        public bool Separator { get; set; }

        [MathMLAttributeName("stretchy")]
        public bool Stretchy { get; set; }

        [MathMLAttributeName("symmetric")]
        public bool Symmetric { get; set; }

        [MathMLAttributeName("lspace")]
        public MathMLLength LeftSpace { get; set; }

        [MathMLAttributeName("rspace")]
        public MathMLLength RightSpace { get; set; }

        [MathMLAttributeName("dir")]
        public MathMLTextDirection TextDirection { get; set; }

        [MathMLAttributeName("mathvariant")]
        public MathMLMathVariant MathVariant { get; set; }
    }
}
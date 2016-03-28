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
        [DefaultValue(false)]
        public bool Accent { get; set; }

        [MathMLAttributeName("fence")]
        [DefaultValue(false)]
        public bool Fence { get; set; }

        [MathMLAttributeName("form")]
        [DefaultValue(MathMLOperatorForm.Infix)]
        public MathMLOperatorForm Form { get; set; }

        [MathMLAttributeName("largeop")]
        [DefaultValue(false)]
        public bool LargeOperator { get; set; }

        [MathMLAttributeName("movablelimits")]
        [DefaultValue(false)]
        public bool MovableLimits { get; set; }

        [MathMLAttributeName("separator")]
        [DefaultValue(false)]
        public bool Separator { get; set; }

        [MathMLAttributeName("stretchy")]
        [DefaultValue(false)]
        public bool Stretchy { get; set; }

        [MathMLAttributeName("symmetric")]
        [DefaultValue(false)]
        public bool Symmetric { get; set; }

        [MathMLAttributeName("lspace")]
        public MathMLLength LeftSpace { get; set; }

        [MathMLAttributeName("rspace")]
        public MathMLLength RightSpace { get; set; }

        [MathMLAttributeName("dir")]
        [DefaultValue(MathMLTextDirection.LeftToRight)]
        public MathMLTextDirection TextDirection { get; set; }

        [MathMLAttributeName("mathvariant")]
        [DefaultValue(MathMLMathVariant.Normal)]
        public MathMLMathVariant MathVariant { get; set; }

        public MathMLOperator()
        {
            Accent = false;
            Fence = false;
            Form = MathMLOperatorForm.Infix;
            LargeOperator = false;
            MovableLimits = false;
            Separator = false;
            Stretchy = false;
            Symmetric = false;
            TextDirection = MathMLTextDirection.LeftToRight;
            MathVariant = MathMLMathVariant.Normal;
        }
    }
}
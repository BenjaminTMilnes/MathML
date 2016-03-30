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
        [MathMLAttributeOrderIndex(12)]
        [DefaultValue(false)]
        public bool Accent { get; set; }

        [MathMLAttributeName("fence")]
        [MathMLAttributeOrderIndex(13)]
        [DefaultValue(false)]
        public bool Fence { get; set; }

        [MathMLAttributeName("form")]
        [MathMLAttributeOrderIndex(9)]
        [DefaultValue(MathMLOperatorForm.Infix)]
        public MathMLOperatorForm Form { get; set; }

        [MathMLAttributeName("largeop")]
        [MathMLAttributeOrderIndex(10)]
        [DefaultValue(false)]
        public bool LargeOperator { get; set; }

        [MathMLAttributeName("movablelimits")]
        [MathMLAttributeOrderIndex(11)]
        [DefaultValue(false)]
        public bool MovableLimits { get; set; }

        [MathMLAttributeName("separator")]
        [MathMLAttributeOrderIndex(14)]
        [DefaultValue(false)]
        public bool Separator { get; set; }

        [MathMLAttributeName("stretchy")]
        [MathMLAttributeOrderIndex(15)]
        [DefaultValue(false)]
        public bool Stretchy { get; set; }

        [MathMLAttributeName("symmetric")]
        [MathMLAttributeOrderIndex(16)]
        [DefaultValue(false)]
        public bool Symmetric { get; set; }

        [MathMLAttributeName("lspace")]
        [MathMLAttributeOrderIndex(17)]
        public MathMLMeasuredLength LeftSpace { get; set; }

        [MathMLAttributeName("rspace")]
        [MathMLAttributeOrderIndex(18)]
        public MathMLMeasuredLength RightSpace { get; set; }

        [MathMLAttributeName("dir")]
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(MathMLTextDirection.LeftToRight)]
        public MathMLTextDirection TextDirection { get; set; }

        [MathMLAttributeName("mathvariant")]
        [MathMLAttributeOrderIndex(8)]
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
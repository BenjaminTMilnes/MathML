using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mi")]
    public class MathMLIdentifier : MathMLElement
    {
        [MathMLAttributeName("dir")]
        [DefaultValue(MathMLTextDirection.LeftToRight)]
        public MathMLTextDirection TextDirection { get; set; }

        [MathMLAttributeName("mathvariant")]
        [DefaultValue(MathMLMathVariant.Normal)]
        public MathMLMathVariant MathVariant { get; set; }
    }
}

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
        public MathMLTextDirection TextDirection { get; set; }
        
        [MathMLAttributeName("mathvariant")]
        public MathMLMathVariant MathVariant { get; set; }
    }
}

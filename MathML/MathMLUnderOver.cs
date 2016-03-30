using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("munderover")]
    public class MathMLUnderOver : MathMLElement
    {
        [MathMLAttributeName("accent")]
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(false)]
        public bool AccentOver { get; set; }

        [MathMLAttributeName("accentunder")]
        [MathMLAttributeOrderIndex(8)]
        [DefaultValue(false)]
        public bool AccentUnder { get; set; }

        [MathMLAttributeName("align")]
        [MathMLAttributeOrderIndex(9)]
        [DefaultValue(MathMLUnderOverAlignment.Center)]
        public MathMLUnderOverAlignment Alignment { get; set; }

        public MathMLUnderOver()
        {
            AccentOver = false;
            AccentUnder = false;
            Alignment = MathMLUnderOverAlignment.Center;
        }
    }
}

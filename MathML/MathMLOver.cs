using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mover")]
    public class MathMLOver : MathMLElement
    {
        [MathMLAttributeName("accent")]
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(false)]
        public bool Accent { get; set; }

        public MathMLOver() : this(false) { }

        public MathMLOver(bool accent)
        {
            Accent = accent;
        }
    }
}

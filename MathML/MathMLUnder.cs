using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("munder")]
    public class MathMLUnder : MathMLElement
    {
        [MathMLAttributeName("accentunder")]
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(false)]
        public bool Accent { get; set; }

        public MathMLUnder() : this(false) { }

        public MathMLUnder(bool accent)
        {
            Accent = accent;
        }
    }
}


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
        public bool Accent { get; set; }
    }
}

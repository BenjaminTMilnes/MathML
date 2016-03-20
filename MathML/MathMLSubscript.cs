using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("msub")]
    public class MathMLSubscript : MathMLElement
    {
        [MathMLAttributeName("subscriptshift")]
        public MathMLLength Shift { get; set; }
    }
}

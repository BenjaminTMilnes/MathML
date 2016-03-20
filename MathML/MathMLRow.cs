using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mrow")]
    public class MathMLRow : MathMLElement
    {
        [MathMLAttributeName("dir")]
        public MathMLTextDirection TextDirection { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mfenced")]
    public class MathMLFenced : MathMLElement
    {
        [MathMLAttributeName("open")]
        public string Open { get; set; }

        [MathMLAttributeName("separators")]
        public string Separators { get; set; }

        [MathMLAttributeName("close")]
        public string Close { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("msup")]
    public class MathMLSuperscript : MathMLElement
    {
        [MathMLAttributeName("superscriptshift")]
        public MathMLMeasuredLength Shift { get; set; }
    }
}

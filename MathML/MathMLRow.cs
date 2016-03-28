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
        [DefaultValue(MathMLTextDirection.LeftToRight)]
        public MathMLTextDirection TextDirection { get; set; }

        public MathMLRow()
        {
            TextDirection = MathMLTextDirection.LeftToRight;
        }
    }
}

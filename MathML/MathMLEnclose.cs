using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("menclose")]
    public class MathMLEnclose : MathMLElement
    {
        [MathMLAttributeName("notation")]
        public MathMLEncloseNotation Notation { get; set; }
    }
}

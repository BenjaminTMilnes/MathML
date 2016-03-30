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
        [MathMLAttributeOrderIndex(7)]
        public MathMLEncloseNotation Notation { get; set; }

        public MathMLEnclose() : this(MathMLEncloseNotation.LongDivision) { }

        public MathMLEnclose(MathMLEncloseNotation notation)
        {
            Notation = notation;
        }
    }
}

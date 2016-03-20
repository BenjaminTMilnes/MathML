using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mfrac")]
    public class MathMLFraction : MathMLElement
    {
        [MathMLAttributeName("bevelled")]
        public bool Bevelled { get; set; }

        [MathMLAttributeName("denomalign")]
        public MathMLFractionPartAlignment DenominatorAlignment { get; set; }

        [MathMLAttributeName("numalign")]
        public MathMLFractionPartAlignment NumeratorAlignment { get; set; }
    }
}
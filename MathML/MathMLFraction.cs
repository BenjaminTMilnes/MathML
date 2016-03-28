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
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(false)]
        public bool Bevelled { get; set; }

        [MathMLAttributeName("numalign")]
        [MathMLAttributeOrderIndex(8)]
        [DefaultValue(MathMLFractionPartAlignment.Center)]
        public MathMLFractionPartAlignment NumeratorAlignment { get; set; }

        [MathMLAttributeName("denomalign")]
        [MathMLAttributeOrderIndex(9)]
        [DefaultValue(MathMLFractionPartAlignment.Center)]
        public MathMLFractionPartAlignment DenominatorAlignment { get; set; }

        public MathMLFraction() : this(false, MathMLFractionPartAlignment.Center, MathMLFractionPartAlignment.Center) { }

        public MathMLFraction(bool bevelled, MathMLFractionPartAlignment denominatorAlignment, MathMLFractionPartAlignment numeratorAlignment)
        {
            Bevelled = bevelled;
            DenominatorAlignment = denominatorAlignment;
            NumeratorAlignment = numeratorAlignment;
        }
    }
}
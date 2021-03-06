﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("math")]
    public class MathMLMath : MathMLElement
    {
        [MathMLAttributeName("display")]
        [DefaultValue(MathMLDisplay.Block)]
        public MathMLDisplay Display { get; set; }

        [MathMLAttributeName("overflow")]
        [DefaultValue(MathMLOverflow.LineBreak)]
        public MathMLOverflow Overflow { get; set; }

        public MathMLMath() : this(MathMLDisplay.Block, MathMLOverflow.LineBreak) { }

        public MathMLMath(MathMLDisplay display) : this(display, MathMLOverflow.LineBreak) { }

        public MathMLMath(MathMLDisplay display, MathMLOverflow overflow)
        {
            Display = display;
            Overflow = overflow;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mglyph")]
    public class MathMLGlyph : MathMLElement
    {
        [MathMLAttributeName("src")]
        [MathMLAttributeOrderIndex(7)]
        public string Source { get; set; }

        [MathMLAttributeName("alt")]
        [MathMLAttributeOrderIndex(8)]
        public string AlternativeText { get; set; }

        [MathMLAttributeName("width")]
        [MathMLAttributeOrderIndex(9)]
        public MathMLMeasuredLength Width { get; set; }

        [MathMLAttributeName("height")]
        [MathMLAttributeOrderIndex(10)]
        public MathMLMeasuredLength Height { get; set; }

        [MathMLAttributeName("valign")]
        [MathMLAttributeOrderIndex(11)]
        public MathMLMeasuredLength VerticalAlignment { get; set; }
    }
}
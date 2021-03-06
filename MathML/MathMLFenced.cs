﻿using System;
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
        [DefaultValue("(")]
        public string Open { get; set; }

        [MathMLAttributeName("separators")]
        [DefaultValue(",")]
        public string Separators { get; set; }

        [MathMLAttributeName("close")]
        [DefaultValue(")")]
        public string Close { get; set; }

        public MathMLFenced() : this("(", ",", ")") { }

        public MathMLFenced(string open, string close) : this(open, ",", close) { }

        public MathMLFenced(string open, string separators, string close)
        {
            Open = open;
            Separators = separators;
            Close = close;
        }
    }
}
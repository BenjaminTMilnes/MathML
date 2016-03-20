﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("munder")]
    public class MathMLUnderscript : MathMLElement
    {
        [MathMLAttributeName("accentunder")]
        public bool Accent { get; set; }
    }
}


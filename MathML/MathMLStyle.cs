using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mstyle")]
    public class MathMLStyle : MathMLElement
    {
        [MathMLAttributeName("dir")]
        public MathMLTextDirection TextDirection { get; set; }

        [MathMLAttributeName("decimalpoint")]
        public char DecimalPoint { get; set; }

        [MathMLAttributeName("displaystyle")]
        public bool DisplayStyle { get; set; }

        [MathMLAttributeName("infixlinebreakstyle")]
        public MathMLInfixLineBreakStyle InfixLineBreakStyle { get; set; }

        [MathMLAttributeName("scriptlevel")]
        public int ScriptLevel { get; set; }

        [MathMLAttributeName("scriptminsize")]
        public MathMLLength ScriptMinimumSize { get; set; }

        [MathMLAttributeName("scriptsizemultiplier")]
        public double ScriptSizeMultiplier { get; set; }
    }
}

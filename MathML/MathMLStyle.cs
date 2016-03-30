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
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(MathMLTextDirection.LeftToRight)]
        public MathMLTextDirection TextDirection { get; set; }

        [MathMLAttributeName("displaystyle")]
        [MathMLAttributeOrderIndex(8)]
        [DefaultValue(true)]
        public bool DisplayStyle { get; set; }

        [MathMLAttributeName("decimalpoint")]
        [MathMLAttributeOrderIndex(9)]
        [DefaultValue('.')]
        public char DecimalPoint { get; set; }

        [MathMLAttributeName("infixlinebreakstyle")]
        [MathMLAttributeOrderIndex(10)]
        [DefaultValue(MathMLInfixLineBreakStyle.Before)]
        public MathMLInfixLineBreakStyle InfixLineBreakStyle { get; set; }

        [MathMLAttributeName("scriptlevel")]
        [MathMLAttributeOrderIndex(11)]
        [DefaultValue(0)]
        public int ScriptLevel { get; set; }

        [MathMLAttributeName("scriptminsize")]
        [MathMLAttributeOrderIndex(12)]
        public MathMLMeasuredLength ScriptMinimumSize { get; set; }

        [MathMLAttributeName("scriptsizemultiplier")]
        [MathMLAttributeOrderIndex(13)]
        [DefaultValue(0.71)]
        public double ScriptSizeMultiplier { get; set; }

        public MathMLStyle()
        {
            TextDirection = MathMLTextDirection.LeftToRight;
            DisplayStyle = true;
            DecimalPoint = '.';
            InfixLineBreakStyle = MathMLInfixLineBreakStyle.Before;
            ScriptLevel = 0;
            ScriptSizeMultiplier = 0.71;
        }
    }
}

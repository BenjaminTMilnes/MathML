using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLEncloseNotation
    {
        [MathMLAttributeValue("longdiv")]
        LongDivision = 0,

        [MathMLAttributeValue("actuarial")]
        Actuarial = 1,

        [MathMLAttributeValue("radical")]
        Radical = 2,

        [MathMLAttributeValue("box")]
        Box = 3,

        [MathMLAttributeValue("roundedbox")]
        RoundedBox = 4,

        [MathMLAttributeValue("circle")]
        Circle = 5,

        [MathMLAttributeValue("left")]
        Left = 6,

        [MathMLAttributeValue("right")]
        Right = 7,

        [MathMLAttributeValue("top")]
        Top = 8,

        [MathMLAttributeValue("bottom")]
        Bottom = 9,

        [MathMLAttributeValue("updiagonalstrike")]
        UpDiagonalStrike = 10,

        [MathMLAttributeValue("downdiagonalstrike")]
        DownDiagonalStrike = 11,

        [MathMLAttributeValue("verticalstrike")]
        VerticalStrike = 12,

        [MathMLAttributeValue("horizontalstrike")]
        HorizontalStrike = 13,

        [MathMLAttributeValue("madruwb")]
        Madruwb = 14,

        [MathMLAttributeValue("updiagonalarrow")]
        UpDiagonalArrow = 15,

        [MathMLAttributeValue("phasorangle")]
        PhasorAngle = 16
    }
}

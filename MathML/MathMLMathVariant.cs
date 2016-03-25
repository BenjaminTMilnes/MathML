using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public enum MathMLMathVariant
    {
        [MathMLAttributeValue("normal")]
        Normal = 0,

        [MathMLAttributeValue("bold")]
        Bold = 1,

        [MathMLAttributeValue("italic")]
        Italic = 2,

        [MathMLAttributeValue("bold-italic")]
        BoldItalic = 3,

        [MathMLAttributeValue("double-struck")]
        DoubleStruck = 4,

        [MathMLAttributeValue("bold-fraktur")]
        BoldFraktur = 5,

        [MathMLAttributeValue("script")]
        Script = 6,

        [MathMLAttributeValue("bold-script")]
        BoldScript = 7,

        [MathMLAttributeValue("fraktur")]
        Fraktur = 8,

        [MathMLAttributeValue("sans-serif")]
        SansSerif = 9,

        [MathMLAttributeValue("bold-sans-serif")]
        BoldSansSerif = 10,

        [MathMLAttributeValue("sans-serif-italic")]
        ItalicSansSerif = 11,

        [MathMLAttributeValue("sans-serif-bold-italic")]
        BoldItalicSansSerif = 12,

        [MathMLAttributeValue("monospace")]
        Monospace = 13,

        [MathMLAttributeValue("initial")]
        Initial = 14,

        [MathMLAttributeValue("tailed")]
        Tailed = 15,

        [MathMLAttributeValue("looped")]
        Looped = 16,

        [MathMLAttributeValue("stretched")]
        Stretched = 17
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public static class MathMLNamedColors
    {
        public static MathMLNamedColor Black { get { return new MathMLNamedColor("black", new MathMLRGBColor("#000000")); } }
        public static MathMLNamedColor Silver { get { return new MathMLNamedColor("silver", new MathMLRGBColor("#c0c0c0")); } }
        public static MathMLNamedColor Gray { get { return new MathMLNamedColor("gray", new MathMLRGBColor("#808080")); } }
        public static MathMLNamedColor White { get { return new MathMLNamedColor("white", new MathMLRGBColor("#ffffff")); } }
    }
}

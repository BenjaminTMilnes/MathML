using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class MathMLNamedColor : MathMLColor
    {
        public string Name { get; private set; }
        public MathMLRGBColor RGBColor { get; private set; }

        public MathMLNamedColor(string name, MathMLRGBColor rgbColor)
        {
            Name = name;
            RGBColor = rgbColor;
        }
    }
}

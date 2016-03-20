using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class MathMLIdentifier : MathMLElement
    {
        public MathMLTextDirection TextDirection { get; set; }
        public string HRef { get; set; }
        public MathMLMathVariant MathVariant { get; set; }
    }
}

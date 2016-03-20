using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class MathMLLength
    {
        public double Quantity { get; private set; }
        public MathMLLengthUnit Units { get; private set; }

        public MathMLLength(double quantity, MathMLLengthUnit units)
        {
            Quantity = quantity;
            Units = units;
        }
    }
}

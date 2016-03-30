using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class MathMLMeasuredLength
    {
        public double Quantity { get; private set; }
        public MathMLMeasuredLengthUnit Units { get; private set; }

        public MathMLMeasuredLength(double quantity, MathMLMeasuredLengthUnit units)
        {
            Quantity = quantity;
            Units = units;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public interface IMathMLNode
    {
        IMathMLNode Parent { get; set; }
    }
}

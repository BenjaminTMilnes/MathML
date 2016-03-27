using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class MathMLTextNode : IMathMLNode
    {
        public IMathMLNode Parent { get; set; }
        public string Content { get; set; }

        public MathMLTextNode(string content)
        {
            Content = content;
        }
    }
}

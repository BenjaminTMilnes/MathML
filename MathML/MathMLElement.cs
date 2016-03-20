using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class MathMLElement
    {
        [MathMLAttributeName("id")]
        public string Id { get; set; }

        [MathMLAttributeName("class")]
        public string StyleClass { get; set; }

        [MathMLAttributeName("style")]
        public string Style { get; set; }

        [MathMLAttributeName("href")]
        public string HRef { get; set; }
    }
}

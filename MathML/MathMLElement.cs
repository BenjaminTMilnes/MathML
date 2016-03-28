using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public abstract class MathMLElement : IMathMLNode
    {
        [MathMLAttributeName("id")]
        [MathMLAttributeOrderIndex(1)]
        [DefaultValue("")]
        public string Id { get; set; }

        [MathMLAttributeName("class")]
        [MathMLAttributeOrderIndex(2)]
        [DefaultValue("")]
        public string StyleClass { get; set; }

        [MathMLAttributeName("style")]
        [MathMLAttributeOrderIndex(3)]
        [DefaultValue("")]
        public string Style { get; set; }

        [MathMLAttributeName("href")]
        [MathMLAttributeOrderIndex(4)]
        [DefaultValue("")]
        public string HRef { get; set; }

        [MathMLAttributeName("mathbackground")]
        [MathMLAttributeOrderIndex(5)]
        public MathMLColor MathBackgroundColor { get; set; }

        [MathMLAttributeName("mathcolor")]
        [MathMLAttributeOrderIndex(6)]
        public MathMLColor MathColor { get; set; }

        public IMathMLNode Parent { get; set; }
        public IList<IMathMLNode> Children { get; set; }

        public MathMLElement()
        {
            Id = "";
            StyleClass = "";
            Style = "";
            HRef = "";
            Parent = null;
            Children = new List<IMathMLNode>();
        }
    }
}

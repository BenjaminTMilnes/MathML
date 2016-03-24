using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mtd")]
    public class MathMLTableCell : MathMLElement
    {
        [MathMLAttributeName("columnalign")]
        public MathMLTableColumnAlignment ColumnAlignment { get; set; }

        [MathMLAttributeName("columnspan")]
        public int ColumnSpan { get; set; }

        [MathMLAttributeName("rowalign")]
        public MathMLTableVerticalAlignment RowAlignment { get; set; }

        [MathMLAttributeName("rowspan")]
        public int RowSpan { get; set; }
    }
}

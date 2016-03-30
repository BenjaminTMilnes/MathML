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
        [MathMLAttributeName("rowspan")]
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(1)]
        public int RowSpan { get; set; }

        [MathMLAttributeName("rowalign")]
        [MathMLAttributeOrderIndex(8)]
        [DefaultValue(MathMLTableVerticalAlignment.Baseline)]
        public MathMLTableVerticalAlignment RowAlignment { get; set; }

        [MathMLAttributeName("columnspan")]
        [MathMLAttributeOrderIndex(9)]
        [DefaultValue(1)]
        public int ColumnSpan { get; set; }

        [MathMLAttributeName("columnalign")]
        [MathMLAttributeOrderIndex(10)]
        [DefaultValue(MathMLTableColumnAlignment.Center)]
        public MathMLTableColumnAlignment ColumnAlignment { get; set; }

        public MathMLTableCell()
        {
            RowSpan = 1;
            RowAlignment = MathMLTableVerticalAlignment.Baseline;
            ColumnSpan = 1;
            ColumnAlignment = MathMLTableColumnAlignment.Center;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mtr")]
    public class MathMLTableRow : MathMLElement
    {
        [MathMLAttributeName("rowalign")]
        [MathMLAttributeOrderIndex(7)]
        [DefaultValue(MathMLTableVerticalAlignment.Baseline)]
        public MathMLTableVerticalAlignment RowAlignment { get; set; }

        [MathMLAttributeName("columnalign")]
        [MathMLAttributeOrderIndex(8)]
        [DefaultValue(MathMLTableColumnAlignment.Center)]
        public MathMLTableColumnAlignment ColumnAlignment { get; set; }

        public MathMLTableRow()
        {
            RowAlignment = MathMLTableVerticalAlignment.Baseline;
            ColumnAlignment = MathMLTableColumnAlignment.Center;
        }
    }
}

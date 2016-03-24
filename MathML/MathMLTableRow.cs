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
        [MathMLAttributeName("columnalign")]
        public MathMLTableColumnAlignment ColumnAlignment { get; set; }

        [MathMLAttributeName("rowalign")]
        public MathMLTableVerticalAlignment RowAlignment { get; set; }
    }
}

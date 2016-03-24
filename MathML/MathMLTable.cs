using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    [MathMLElementName("mtable")]
    public class MathMLTable : MathMLElement
    {
        [MathMLAttributeName("align")]
        public MathMLTableVerticalAlignment VerticalAlignment { get; set; }

        [MathMLAttributeName("columnalign")]
        public IList<MathMLTableColumnAlignment> ColumnAlignment { get; set; }

        [MathMLAttributeName("columnlines")]
        public IList<MathMLTableLineStyle> ColumnLineStyle { get; set; }

        [MathMLAttributeName("columnspacing")]
        public MathMLLength ColumnSpacing { get; set; }

        [MathMLAttributeName("columnwidth")]
        public MathMLLength ColumnWidth { get; set; }

        [MathMLAttributeName("displaystyle")]
        public bool DisplayStyle { get; set; }

        [MathMLAttributeName("equalcolumns")]
        public bool EqualColumnHeights { get; set; }

        [MathMLAttributeName("equalrows")]
        public bool EqualRowHeights { get; set; }

        [MathMLAttributeName("frame")]
        public MathMLTableLineStyle Frame { get; set; }

        [MathMLAttributeName("framespacing")]
        public MathMLLength FrameSpacing { get; set; }

        [MathMLAttributeName("minlabelspacing")]
        public MathMLLength MinimumLabelSpacing { get; set; }

        [MathMLAttributeName("rowalign")]
        public IList<MathMLTableVerticalAlignment> RowAlignment { get; set; }

        [MathMLAttributeName("rowlines")]
        public IList<MathMLTableLineStyle> RowLineStyle { get; set; }

        [MathMLAttributeName("rowspacing")]
        public MathMLLength RowSpacing { get; set; }

        [MathMLAttributeName("side")]
        public MathMLLabeledTableRowPlacement Side { get; set; }

        [MathMLAttributeName("width")]
        public MathMLLength Width { get; set; }
    }
}
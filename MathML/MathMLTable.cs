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
        [DefaultValue(MathMLTableVerticalAlignment.Axis)]
        public MathMLTableVerticalAlignment VerticalAlignment { get; set; }

        [MathMLAttributeName("columnalign")]
        public IList<MathMLTableColumnAlignment> ColumnAlignment { get; set; }

        [MathMLAttributeName("columnlines")]
        public IList<MathMLTableLineStyle> ColumnLineStyle { get; set; }

        [MathMLAttributeName("columnspacing")]
        public MathMLMeasuredLength ColumnSpacing { get; set; }

        [MathMLAttributeName("columnwidth")]
        public MathMLMeasuredLength ColumnWidth { get; set; }

        [MathMLAttributeName("displaystyle")]
        [DefaultValue(true)]
        public bool DisplayStyle { get; set; }

        [MathMLAttributeName("equalcolumns")]
        [DefaultValue(false)]
        public bool EqualColumnHeights { get; set; }

        [MathMLAttributeName("equalrows")]
        [DefaultValue(false)]
        public bool EqualRowHeights { get; set; }

        [MathMLAttributeName("frame")]
        [DefaultValue(MathMLTableLineStyle.None)]
        public MathMLTableLineStyle Frame { get; set; }

        [MathMLAttributeName("framespacing")]
        public MathMLMeasuredLength FrameSpacing { get; set; }

        [MathMLAttributeName("minlabelspacing")]
        public MathMLMeasuredLength MinimumLabelSpacing { get; set; }

        [MathMLAttributeName("rowalign")]
        public IList<MathMLTableVerticalAlignment> RowAlignment { get; set; }

        [MathMLAttributeName("rowlines")]
        public IList<MathMLTableLineStyle> RowLineStyle { get; set; }

        [MathMLAttributeName("rowspacing")]
        public MathMLMeasuredLength RowSpacing { get; set; }

        [MathMLAttributeName("side")]
        [DefaultValue(MathMLLabeledTableRowPlacement.Right)]
        public MathMLLabeledTableRowPlacement Side { get; set; }

        [MathMLAttributeName("width")]
        public MathMLMeasuredLength Width { get; set; }

        public MathMLTable()
        {
            VerticalAlignment = MathMLTableVerticalAlignment.Axis;
            DisplayStyle = true;
            EqualColumnHeights = false;
            EqualRowHeights = false;
            Frame = MathMLTableLineStyle.None;
            Side = MathMLLabeledTableRowPlacement.Right;
        }
    }
}
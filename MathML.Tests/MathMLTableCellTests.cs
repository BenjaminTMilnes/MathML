using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathML;

namespace MathML.Tests
{
    [TestClass]
    public class MathMLTableCellTests
    {
        private MathMLSerializer _serializer;

        public MathMLTableCellTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLTableCellTest()
        {
            Assert.AreEqual("<mtd></mtd>", _serializer.SerializeMathMLNode(new MathMLTableCell()));
        }

        [TestMethod]
        public void MathMLTableCellWithAllAttributesTest()
        {
            Assert.AreEqual("<mtd rowspan=\"2\" rowalign=\"center\" columnspan=\"2\" columnalign=\"right\"></mtd>", _serializer.SerializeMathMLNode(new MathMLTableCell() { RowSpan = 2, RowAlignment = MathMLTableVerticalAlignment.Center, ColumnSpan = 2, ColumnAlignment = MathMLTableColumnAlignment.Right }));
        }
    }
}

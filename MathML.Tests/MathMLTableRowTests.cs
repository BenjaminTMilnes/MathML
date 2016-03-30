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
    public class MathMLTableRowTests
    {
        private MathMLSerializer _serializer;

        public MathMLTableRowTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLTableRowTest()
        {
            Assert.AreEqual("<mtr></mtr>", _serializer.SerializeMathMLNode(new MathMLTableRow()));
        }

        [TestMethod]
        public void MathMLTableRowWithAllAttributesTest()
        {
            Assert.AreEqual("<mtr rowalign=\"center\" columnalign=\"right\"></mtr>", _serializer.SerializeMathMLNode(new MathMLTableRow() { RowAlignment = MathMLTableVerticalAlignment.Center, ColumnAlignment = MathMLTableColumnAlignment.Right }));
        }
    }
}

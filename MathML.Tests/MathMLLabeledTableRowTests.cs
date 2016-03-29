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
    public class MathMLLabeledTableRowTests
    {
        private MathMLSerializer _serializer;

        public MathMLLabeledTableRowTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLLabeledTableRowTest()
        {
            Assert.AreEqual("<mlabeledtr></mlabeledtr>", _serializer.SerializeMathMLNode(new MathMLLabeledTableRow()));
        }
    }
}

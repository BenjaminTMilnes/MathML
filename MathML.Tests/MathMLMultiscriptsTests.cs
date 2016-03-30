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
    public class MathMLMultiscriptsTests
    {
        private MathMLSerializer _serializer;

        public MathMLMultiscriptsTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLMultiscriptsTest()
        {
            Assert.AreEqual("<mmultiscripts></mmultiscripts>", _serializer.SerializeMathMLNode(new MathMLMultiscripts()));
        }

        [TestMethod]
        public void MathMLMultiscriptsWithAllAttributesTest()
        {
            Assert.AreEqual("<mmultiscripts subscriptshift=\"4pt\" superscriptshift=\"8mm\"></mmultiscripts>", _serializer.SerializeMathMLNode(new MathMLMultiscripts() { SubscriptShift = new MathMLMeasuredLength(4, MathMLMeasuredLengthUnit.Points), SuperscriptShift = new MathMLMeasuredLength(8, MathMLMeasuredLengthUnit.Millimeters) }));
        }
    }
}

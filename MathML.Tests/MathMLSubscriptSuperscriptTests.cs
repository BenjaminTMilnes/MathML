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
    public class MathMLSubscriptSuperscriptTests
    {
        private MathMLSerializer _serializer;

        public MathMLSubscriptSuperscriptTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLSubscriptSuperscriptTest()
        {
            Assert.AreEqual("<msubsup></msubsup>", _serializer.SerializeMathMLNode(new MathMLSubscriptSuperscript()));
        }

        [TestMethod]
        public void MathMLSubscriptSuperscriptWithAllAttributesTest()
        {
            Assert.AreEqual("<msubsup subscriptshift=\"10pt\" superscriptshift=\"15mm\"></msubsup>", _serializer.SerializeMathMLNode(new MathMLSubscriptSuperscript() { SubscriptShift = new MathMLMeasuredLength(10, MathMLMeasuredLengthUnit.Points), SuperscriptShift = new MathMLMeasuredLength(15, MathMLMeasuredLengthUnit.Millimeters) }));
        }
    }
}

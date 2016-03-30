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
    public class MathMLPaddedTests
    {
        private MathMLSerializer _serializer;

        public MathMLPaddedTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLPaddedTest()
        {
            Assert.AreEqual("<mpadded></mpadded>", _serializer.SerializeMathMLNode(new MathMLPadded()));
        }

        [TestMethod]
        public void MathMLPaddedWithAllAttributes()
        {
            Assert.AreEqual("<mpadded width=\"10pt\" height=\"5mm\" depth=\"20px\" lspace=\"1in\" voffset=\"15em\"></mpadded>", _serializer.SerializeMathMLNode(new MathMLPadded() { Width = new MathMLLength(10, MathMLLengthUnit.Points), Height = new MathMLLength(5, MathMLLengthUnit.Millimeters), Depth = new MathMLLength(20, MathMLLengthUnit.Pixels), LeftSpace = new MathMLLength(1, MathMLLengthUnit.Inches), VerticalOffset = new MathMLLength(15, MathMLLengthUnit.Em) }));
        }
    }
}

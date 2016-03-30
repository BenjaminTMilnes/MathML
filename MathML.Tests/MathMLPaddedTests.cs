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
            Assert.AreEqual("<mpadded width=\"10pt\" height=\"5mm\" depth=\"20px\" lspace=\"1in\" voffset=\"15em\"></mpadded>", _serializer.SerializeMathMLNode(new MathMLPadded() { Width = new MathMLMeasuredLength(10, MathMLMeasuredLengthUnit.Points), Height = new MathMLMeasuredLength(5, MathMLMeasuredLengthUnit.Millimeters), Depth = new MathMLMeasuredLength(20, MathMLMeasuredLengthUnit.Pixels), LeftSpace = new MathMLMeasuredLength(1, MathMLMeasuredLengthUnit.Inches), VerticalOffset = new MathMLMeasuredLength(15, MathMLMeasuredLengthUnit.Em) }));
        }
    }
}

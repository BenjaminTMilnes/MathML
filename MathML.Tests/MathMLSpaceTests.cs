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
    public class MathMLSpaceTests
    {
        private MathMLSerializer _serializer;

        public MathMLSpaceTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLSpaceTest()
        {
            Assert.AreEqual("<mspace></mspace>", _serializer.SerializeMathMLNode(new MathMLSpace()));
        }

        [TestMethod]
        public void MathMLSpaceWithAllAttributesTest()
        {
            Assert.AreEqual("<mspace width=\"10pt\" height=\"5mm\" depth=\"20px\" linebreak=\"newline\"></mspace>", _serializer.SerializeMathMLNode(new MathMLSpace() { Width = new MathMLMeasuredLength(10, MathMLMeasuredLengthUnit.Points), Height = new MathMLMeasuredLength(5, MathMLMeasuredLengthUnit.Millimeters), Depth = new MathMLMeasuredLength(20, MathMLMeasuredLengthUnit.Pixels), LineBreak = MathMLLineBreak.NewLine }));
        }
    }
}

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
    public class MathMLGlyphTests
    {
        private MathMLSerializer _serializer;

        public MathMLGlyphTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLGlyphTest()
        {
            Assert.AreEqual("<mglyph></mglyph>", _serializer.SerializeMathMLNode(new MathMLGlyph()));
        }

        [TestMethod]
        public void MathMLGlyphWithAllAttributesTest()
        {
            Assert.AreEqual("<mglyph src=\"somefile.png\" alt=\"Some Text\" width=\"12pt\" height=\"14mm\" valign=\"16px\"></mglyph>", _serializer.SerializeMathMLNode(new MathMLGlyph() { AlternativeText = "Some Text", Source = "somefile.png", Width = new MathMLLength(12, MathMLLengthUnit.Points), Height = new MathMLLength(14, MathMLLengthUnit.Millimeters), VerticalAlignment = new MathMLLength(16, MathMLLengthUnit.Pixels) }));
        }
    }
}

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
    public class MathMLIdentifierTests
    {
        private MathMLSerializer _serializer;

        public MathMLIdentifierTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLIdentifierTest()
        {
            Assert.AreEqual("<mi></mi>", _serializer.SerializeMathMLNode(new MathMLIdentifier()));
        }

        [TestMethod]
        public void MathMLIdentifierWithAllAttributesTest()
        {
            Assert.AreEqual("<mi dir=\"rtl\" mathvariant=\"fraktur\"></mi>", _serializer.SerializeMathMLNode(new MathMLIdentifier() { TextDirection = MathMLTextDirection.RightToLeft, MathVariant = MathMLMathVariant.Fraktur }));
        }

        [TestMethod]
        public void MathMLIdentifierWithContentTest()
        {
            var textNode = new MathMLTextNode("x");
            var identifier = new MathMLIdentifier();

            identifier.Children.Add(textNode);

            Assert.AreEqual("<mi>x</mi>", _serializer.SerializeMathMLNode(identifier));
        }
    }
}

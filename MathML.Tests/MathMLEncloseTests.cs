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
    public class MathMLEncloseTests
    {
        private MathMLSerializer _serializer;

        public MathMLEncloseTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLEncloseTest()
        {
            Assert.AreEqual("<menclose notation=\"longdiv\"></menclose>", _serializer.SerializeMathMLNode(new MathMLEnclose()));
        }

        [TestMethod]
        public void MathMLEncloseWithNotationTest()
        {
            Assert.AreEqual("<menclose notation=\"circle\"></menclose>", _serializer.SerializeMathMLNode(new MathMLEnclose() { Notation = MathMLEncloseNotation.Circle }));
        }

        [TestMethod]
        public void MathMLEncloseWithContentTest()
        {
            var enclose = new MathMLEnclose();
            var identifier = new MathMLIdentifier();
            var textNode = new MathMLTextNode("x");

            identifier.Children.Add(textNode);
            enclose.Children.Add(identifier);

            Assert.AreEqual("<menclose notation=\"longdiv\"><mi>x</mi></menclose>", _serializer.SerializeMathMLNode(enclose));
        }
    }
}

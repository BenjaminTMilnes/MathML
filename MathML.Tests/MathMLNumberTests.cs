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
    public class MathMLNumberTests
    {
        private MathMLSerializer _serializer;

        public MathMLNumberTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLNumberTest()
        {
            Assert.AreEqual("<mn></mn>", _serializer.SerializeMathMLNode(new MathMLNumber()));
        }

        [TestMethod]
        public void MathMLNumberWithContentTest()
        {
            var textNode = new MathMLTextNode("1.2345");
            var number = new MathMLNumber();

            number.Children.Add(textNode);

            Assert.AreEqual("<mn>1.2345</mn>", _serializer.SerializeMathMLNode(number));
        }

        [TestMethod]
        public void MathMLNumberWithIdTest()
        {
            Assert.AreEqual("<mn id=\"number1\"></mn>", _serializer.SerializeMathMLNode(new MathMLNumber() { Id = "number1" }));
        }
    }
}

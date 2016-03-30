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
    public class MathMLTextTests
    {
        private MathMLSerializer _serializer;

        public MathMLTextTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLTextTest()
        {
            Assert.AreEqual("<mtext></mtext>", _serializer.SerializeMathMLNode(new MathMLText()));
        }

        [TestMethod]
        public void MathMLTextWithContentTest()
        {
            var text = new MathMLText();
            var textNode = new MathMLTextNode("perimeter");

            text.Children.Add(textNode);

            Assert.AreEqual("<mtext>perimeter</mtext>", _serializer.SerializeMathMLNode(text));
        }
    }
}

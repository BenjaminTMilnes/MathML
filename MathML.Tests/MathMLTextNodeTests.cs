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
    public class MathMLTextNodeTests
    {
        private MathMLSerializer _serializer;

        public MathMLTextNodeTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLTextNodeTest()
        {
            Assert.AreEqual("", _serializer.SerializeMathMLNode(new MathMLTextNode("")));
        }

        [TestMethod]
        public void MathMLTextNodeWithAlphanumericCharactersTest()
        {
            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz0123456789", _serializer.SerializeMathMLNode(new MathMLTextNode("abcdefghijklmnopqrstuvwxyz0123456789")));
        }
    }
}

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
    public class MathMLUnderTests
    {
        private MathMLSerializer _serializer;

        public MathMLUnderTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLUnderTest()
        {
            Assert.AreEqual("<munder></munder>", _serializer.SerializeMathMLNode(new MathMLUnder()));
        }

        [TestMethod]
        public void MathMLUnderWithAllAttributesTest()
        {
            Assert.AreEqual("<munder accentunder=\"true\"></munder>", _serializer.SerializeMathMLNode(new MathMLUnder() { Accent = true }));
        }
    }
}

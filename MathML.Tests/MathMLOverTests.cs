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
    public class MathMLOverTests
    {
        private MathMLSerializer _serializer;

        public MathMLOverTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLOverTest()
        {
            Assert.AreEqual("<mover></mover>", _serializer.SerializeMathMLNode(new MathMLOver()));
        }

        [TestMethod]
        public void MathMLOverWithAllAttributesTest()
        {
            Assert.AreEqual("<mover accent=\"true\"></mover>", _serializer.SerializeMathMLNode(new MathMLOver() { Accent = true }));
        }
    }
}

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
    public class MathMLSubscriptTests
    {
        private MathMLSerializer _serializer;

        public MathMLSubscriptTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLSubscriptTest()
        {
            Assert.AreEqual("<msub></msub>", _serializer.SerializeMathMLNode(new MathMLSubscript()));
        }

        [TestMethod]
        public void MathMLSubscriptWithAllAttributesTest()
        {
            Assert.AreEqual("<msub subscriptshift=\"10pt\"></msub>", _serializer.SerializeMathMLNode(new MathMLSubscript() { Shift = new MathMLLength(10, MathMLLengthUnit.Points) }));
        }
    }
}

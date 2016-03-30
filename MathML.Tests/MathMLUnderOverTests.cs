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
    public class MathMLUnderOverTests
    {
        private MathMLSerializer _serializer;

        public MathMLUnderOverTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLUnderOverTest()
        {
            Assert.AreEqual("<munderover></munderover>", _serializer.SerializeMathMLNode(new MathMLUnderOver()));
        }

        [TestMethod]
        public void MathMLUnderOverWithAllAttributesTest()
        {
            Assert.AreEqual("<munderover accent=\"true\" accentunder=\"true\" align=\"right\"></munderover>", _serializer.SerializeMathMLNode(new MathMLUnderOver() { AccentOver = true, AccentUnder = true, Alignment = MathMLUnderOverAlignment.Right }));
        }
    }
}

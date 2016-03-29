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
    public class MathMLFencedTests
    {
        private MathMLSerializer _serializer;

        public MathMLFencedTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLFencedTest()
        {
            Assert.AreEqual("<mfenced></mfenced>", _serializer.SerializeMathMLNode(new MathMLFenced()));
        }

        [TestMethod]
        public void MathMLFencedWithOpenAndCloseTest()
        {
            Assert.AreEqual("<mfenced open=\"[\" close=\"]\"></mfenced>", _serializer.SerializeMathMLNode(new MathMLFenced() { Open = "[", Close = "]" }));
        }

        [TestMethod]
        public void MathMLFencedWithOpenCloseAndSeparatorsTest()
        {
            Assert.AreEqual("<mfenced open=\"[\" separators=\";\" close=\"]\"></mfenced>", _serializer.SerializeMathMLNode(new MathMLFenced() { Open = "[", Separators = ";", Close = "]" }));
        }
    }
}

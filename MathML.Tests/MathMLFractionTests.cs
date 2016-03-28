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
    public class MathMLFractionTests
    {
        private MathMLSerializer _serializer;

        public MathMLFractionTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLFractionTest()
        {
            Assert.AreEqual("<mfrac></mfrac>", _serializer.SerializeMathMLNode(new MathMLFraction()));
        }
    }
}

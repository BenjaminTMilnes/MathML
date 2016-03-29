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
    public class MathMLMathTests
    {
        private MathMLSerializer _serializer;

        public MathMLMathTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLMathTest()
        {
            Assert.AreEqual("<math></math>", _serializer.SerializeMathMLNode(new MathMLMath()));
        }

        [TestMethod]
        public void MathMLMathWithAllAttributesTest()
        {
            Assert.AreEqual("<math display=\"inline\" overflow=\"scale\"></math>", _serializer.SerializeMathMLNode(new MathMLMath() { Display = MathMLDisplay.Inline, Overflow = MathMLOverflow.Scale }));
        }
    }
}

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
    public class MathMLSquareRootTests
    {
        private MathMLSerializer _serializer;

        public MathMLSquareRootTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLSquareRootTest()
        {
            Assert.AreEqual("<msqrt></msqrt>", _serializer.SerializeMathMLNode(new MathMLSquareRoot()));
        }
    }
}

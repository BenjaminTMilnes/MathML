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
    public class MathMLLongDivisionTests
    {
        private MathMLSerializer _serializer;

        public MathMLLongDivisionTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLLongDivisionTest()
        {
            Assert.AreEqual("<mlongdiv></mlongdiv>", _serializer.SerializeMathMLNode(new MathMLLongDivision()));
        }
    }
}

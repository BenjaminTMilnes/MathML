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
    public class MathMLTableTests
    {
        private MathMLSerializer _serializer;

        public MathMLTableTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLTableTest()
        {
            Assert.AreEqual("<mtable></mtable>", _serializer.SerializeMathMLNode(new MathMLTable()));
        }
    }
}

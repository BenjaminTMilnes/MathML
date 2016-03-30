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
    public class MathMLRootTests
    {
        private MathMLSerializer _serializer;

        public MathMLRootTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLRootTest()
        {
            Assert.AreEqual("<mroot></mroot>", _serializer.SerializeMathMLNode(new MathMLRoot()));
        }
    }
}

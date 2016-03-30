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
    public class MathMLPhantomTests
    {
        private MathMLSerializer _serializer;

        public MathMLPhantomTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLPhantomTest()
        {
            Assert.AreEqual("<mphantom></mphantom>", _serializer.SerializeMathMLNode(new MathMLPhantom()));
        }
    }
}

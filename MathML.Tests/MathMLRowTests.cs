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
    public class MathMLRowTests
    {
        private MathMLSerializer _serializer;

        public MathMLRowTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLRowTest()
        {
            Assert.AreEqual("<mrow></mrow>", _serializer.SerializeMathMLNode(new MathMLRow()));
        }

        [TestMethod]
        public void MathMLRowWithAllAttributesTest()
        {
            Assert.AreEqual("<mrow dir=\"rtl\"></mrow>", _serializer.SerializeMathMLNode(new MathMLRow() { TextDirection = MathMLTextDirection.RightToLeft }));
        }
    }
}

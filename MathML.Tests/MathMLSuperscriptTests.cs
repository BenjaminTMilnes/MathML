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
    public class MathMLSuperscriptTests
    {
        private MathMLSerializer _serializer;

        public MathMLSuperscriptTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLSuperscriptTest()
        {
            Assert.AreEqual("<msup></msup>", _serializer.SerializeMathMLNode(new MathMLSuperscript()));
        }

        [TestMethod]
        public void MathMLSuperscriptWithAllAttributes()
        {
            Assert.AreEqual("<msup superscriptshift=\"10pt\"></msup>", _serializer.SerializeMathMLNode(new MathMLSuperscript() { Shift = new MathMLMeasuredLength(10, MathMLMeasuredLengthUnit.Points) }));
        }
    }
}

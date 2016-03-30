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
    public class MathMLOperatorTests
    {
        private MathMLSerializer _serializer;

        public MathMLOperatorTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLOperatorTest()
        {
            Assert.AreEqual("<mo></mo>", _serializer.SerializeMathMLNode(new MathMLOperator()));
        }

        [TestMethod]
        public void MathMLOperatorWithContentTest()
        {
            var operator1 = new MathMLOperator();
            var textNode1 = new MathMLTextNode("=");

            operator1.Children.Add(textNode1);

            Assert.AreEqual("<mo>=</mo>", _serializer.SerializeMathMLNode(operator1));
        }

        [TestMethod]
        public void MathMLOperatorWithAllAttributes()
        {
            Assert.AreEqual("<mo dir=\"rtl\" mathvariant=\"bold\" form=\"postfix\" largeop=\"true\" movablelimits=\"true\" accent=\"true\" fence=\"true\" stretchy=\"true\" symmetric=\"true\" lspace=\"10pt\" rspace=\"5mm\"></mo>", _serializer.SerializeMathMLNode(new MathMLOperator() { Accent = true, Fence = true, Form = MathMLOperatorForm.Postfix, LargeOperator = true, MovableLimits = true, Stretchy = true, Symmetric = true, LeftSpace = new MathMLMeasuredLength(10, MathMLMeasuredLengthUnit.Points), RightSpace = new MathMLMeasuredLength(5, MathMLMeasuredLengthUnit.Millimeters), TextDirection = MathMLTextDirection.RightToLeft, MathVariant = MathMLMathVariant.Bold }));
        }
    }
}

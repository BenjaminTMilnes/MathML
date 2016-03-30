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
    public class MathMLStyleTests
    {
        private MathMLSerializer _serializer;

        public MathMLStyleTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void EmptyMathMLStyleTest()
        {
            Assert.AreEqual("<mstyle></mstyle>", _serializer.SerializeMathMLNode(new MathMLStyle()));
        }

        [TestMethod]
        public void MathMLStyleWithAllAttributesTest()
        {
            Assert.AreEqual("<mstyle dir=\"rtl\" displaystyle=\"false\" decimalpoint=\",\" infixlinebreakstyle=\"duplicate\" scriptlevel=\"10\" scriptminsize=\"15mm\" scriptsizemultiplier=\"2.5\"></mstyle>", _serializer.SerializeMathMLNode(new MathMLStyle() { TextDirection = MathMLTextDirection.RightToLeft, DisplayStyle = false, DecimalPoint = ',', InfixLineBreakStyle = MathMLInfixLineBreakStyle.Duplicate, ScriptLevel = 10, ScriptMinimumSize = new MathMLMeasuredLength(15, MathMLMeasuredLengthUnit.Millimeters), ScriptSizeMultiplier = 2.5 }));
        }
    }
}

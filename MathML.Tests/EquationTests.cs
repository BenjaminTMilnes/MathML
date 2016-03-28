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
    public class EquationTests
    {
        private MathMLSerializer _serializer;

        public EquationTests()
        {
            _serializer = new MathMLSerializer();
        }

        [TestMethod]
        public void YEqualsMXPlusCTest()
        {
            var math = new MathMLMath();

            var row = new MathMLRow();

            var identifier1 = new MathMLIdentifier();
            var textNode1 = new MathMLTextNode("y");
            identifier1.Children.Add(textNode1);

            var operator1 = new MathMLOperator();
            var textNode2 = new MathMLTextNode("=");
            operator1.Children.Add(textNode2);

            var identifier2 = new MathMLIdentifier();
            var textNode3 = new MathMLTextNode("m");
            identifier2.Children.Add(textNode3);

            var identifier3 = new MathMLIdentifier();
            var textNode4 = new MathMLTextNode("x");
            identifier3.Children.Add(textNode4);

            var operator2 = new MathMLOperator();
            var textNode5 = new MathMLTextNode("+");
            operator2.Children.Add(textNode5);

            var identifier4 = new MathMLIdentifier();
            var textNode6 = new MathMLTextNode("c");
            identifier4.Children.Add(textNode6);

            row.Children.Add(identifier1);
            row.Children.Add(operator1);
            row.Children.Add(identifier2);
            row.Children.Add(identifier3);
            row.Children.Add(operator2);
            row.Children.Add(identifier4);

            math.Children.Add(row);

            Assert.AreEqual("<math><mrow><mi>y</mi><mo>=</mo><mi>m</mi><mi>x</mi><mo>+</mo><mi>c</mi></mrow></math>", _serializer.SerializeMathMLNode(math));
        }
    }
}

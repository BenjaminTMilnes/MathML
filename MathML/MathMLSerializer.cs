using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class UnknownMathMLNodeException : Exception { }

    public class UnknownMathMLElementException : Exception { }

    public class UnknownMathMLAttributeTypeException : Exception
    { }

    public sealed class MathMLSerializer
    {
        public string SerializeMathMLNode(IMathMLNode node)
        {
            if (node is MathMLElement)
            {
                return SerializeMathMLElement((MathMLElement)node);
            }
            else if (node is MathMLTextNode)
            {
                return SerializeMathMLTextNode((MathMLTextNode)node);
            }

            throw new UnknownMathMLNodeException();
        }

        private string SerializeMathMLTextNode(MathMLTextNode textNode)
        {
            return textNode.Content;
        }

        private string SerializeMathMLElement(MathMLElement element)
        {
            var type = GetMathMLElementType(element);

            var elementName = GetElementName(type);
            var attributes = GetAttributes(type, element);

            var attributeString = string.Join("", attributes.Select(a => string.Format(" {0}=\"{1}\"", a.Item1, a.Item3)));
            var childElementsString = "";

            foreach (var node in element.Children)
            {
                childElementsString += SerializeMathMLNode(node);
            }

            return string.Format("<{0}{1}>{2}</{3}>", elementName, attributeString, childElementsString, elementName);
        }

        private Type GetMathMLElementType(MathMLElement element)
        {
            if (element is MathMLEnclose) return typeof(MathMLEnclose);
            if (element is MathMLFenced) return typeof(MathMLFenced);
            if (element is MathMLFraction) return typeof(MathMLFraction);
            if (element is MathMLGlyph) return typeof(MathMLGlyph);
            if (element is MathMLIdentifier) return typeof(MathMLIdentifier);
            if (element is MathMLLabeledTableRow) return typeof(MathMLLabeledTableRow);
            if (element is MathMLLongDivision) return typeof(MathMLLongDivision);
            if (element is MathMLMath) return typeof(MathMLMath);
            if (element is MathMLMultiscripts) return typeof(MathMLMultiscripts);
            if (element is MathMLNumber) return typeof(MathMLNumber);
            if (element is MathMLOperator) return typeof(MathMLOperator);
            if (element is MathMLOver) return typeof(MathMLOver);
            if (element is MathMLPadded) return typeof(MathMLPadded);
            if (element is MathMLPhantom) return typeof(MathMLPhantom);
            if (element is MathMLRoot) return typeof(MathMLRoot);
            if (element is MathMLRow) return typeof(MathMLRow);
            if (element is MathMLSpace) return typeof(MathMLSpace);
            if (element is MathMLSquareRoot) return typeof(MathMLSquareRoot);
            if (element is MathMLStyle) return typeof(MathMLStyle);
            if (element is MathMLSubscript) return typeof(MathMLSubscript);
            if (element is MathMLSubscriptSuperscript) return typeof(MathMLSubscriptSuperscript);
            if (element is MathMLSuperscript) return typeof(MathMLSuperscript);
            if (element is MathMLTable) return typeof(MathMLTable);
            if (element is MathMLTableCell) return typeof(MathMLTableCell);
            if (element is MathMLTableRow) return typeof(MathMLTableRow);
            if (element is MathMLText) return typeof(MathMLText);
            if (element is MathMLUnder) return typeof(MathMLUnder);
            if (element is MathMLUnderOver) return typeof(MathMLUnderOver);

            throw new UnknownMathMLElementException();
        }

        private string GetElementName(Type type)
        {
            return ((MathMLElementName)Attribute.GetCustomAttribute(type, typeof(MathMLElementName))).ElementName;
        }

        private IEnumerable<Tuple<string, int, string>> GetAttributes(Type type, MathMLElement element)
        {
            var attributes = new List<Tuple<string, int, string>>();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                var isAttribute = false;
                var attributeName = "";
                var attributeOrderIndex = 100;

                object defaultPropertyValue = null;

                var propertyAttributes = property.GetCustomAttributes(true);

                foreach (var propertyAttribute in propertyAttributes)
                {
                    if (propertyAttribute is MathMLAttributeName)
                    {
                        isAttribute = true;
                        attributeName = ((MathMLAttributeName)propertyAttribute).AttributeName;
                    }
                    else if (propertyAttribute is MathMLAttributeOrderIndex)
                    {
                        attributeOrderIndex = ((MathMLAttributeOrderIndex)propertyAttribute).OrderIndex;
                    }
                    else if (propertyAttribute is DefaultValue)
                    {
                        defaultPropertyValue = ((DefaultValue)propertyAttribute).Value;
                    }
                }

                if (isAttribute)
                {
                    var propertyValue = property.GetValue(element, null);

                    var attributeValue = SerializeAttributeValue(propertyValue);
                    var defaultAttributeValue = SerializeAttributeValue(defaultPropertyValue);

                    if (attributeValue != defaultAttributeValue)
                    {
                        attributes.Add(new Tuple<string, int, string>(attributeName, attributeOrderIndex, attributeValue));
                    }
                }
            }

            return attributes.OrderBy(a => a.Item2);
        }

        private string SerializeAttributeValue(object value)
        {
            if (value == null) return "";
            else if (value is int) return ((int)value).ToString();
            else if (value is double) return ((double)value).ToString();
            else if (value is bool) return SerializeBoolean((bool)value);
            else if (value is char) return ((char)value).ToString();
            else if (value is string) return (string)value;
            else if (value is MathMLDisplay) return SerializeEnumeration((MathMLDisplay)value);
            else if (value is MathMLEncloseNotation) return SerializeEnumeration((MathMLEncloseNotation)value);
            else if (value is MathMLFractionPartAlignment) return SerializeEnumeration((MathMLFractionPartAlignment)value);
            else if (value is MathMLInfixLineBreakStyle) return SerializeEnumeration((MathMLInfixLineBreakStyle)value);
            else if (value is MathMLLabeledTableRowPlacement) return SerializeEnumeration((MathMLLabeledTableRowPlacement)value);
            else if (value is MathMLLineBreak) return SerializeEnumeration((MathMLLineBreak)value);
            else if (value is MathMLMathVariant) return SerializeEnumeration((MathMLMathVariant)value);
            else if (value is MathMLOperatorForm) return SerializeEnumeration((MathMLOperatorForm)value);
            else if (value is MathMLOverflow) return SerializeEnumeration((MathMLOverflow)value);
            else if (value is MathMLTableColumnAlignment) return SerializeEnumeration((MathMLTableColumnAlignment)value);
            else if (value is MathMLTableLineStyle) return SerializeEnumeration((MathMLTableLineStyle)value);
            else if (value is MathMLTableVerticalAlignment) return SerializeEnumeration((MathMLTableVerticalAlignment)value);
            else if (value is MathMLTextDirection) return SerializeEnumeration((MathMLTextDirection)value);
            else if (value is MathMLUnderOverAlignment) return SerializeEnumeration((MathMLUnderOverAlignment)value);
            else if (value is MathMLLength) return SerializeMathMLLength((MathMLLength)value);
            else if (value is MathMLColor) return SerializeMathMLColor((MathMLColor)value);

            throw new UnknownMathMLAttributeTypeException();
        }

        private string SerializeBoolean(bool value)
        {
            if (value == true) return "true";
            else return "false";
        }

        private string SerializeEnumeration<T>(T value)
        {
            var enumerationType = typeof(T);
            var member = enumerationType.GetMember(Enum.GetName(typeof(T), value));
            var attribute = member[0].GetCustomAttributes(typeof(MathMLAttributeValue), true)[0];

            return ((MathMLAttributeValue)attribute).Value;
        }

        private string SerializeMathMLLength(MathMLLength length)
        {
            return string.Format("{0}{1}", length.Quantity.ToString(), SerializeEnumeration(length.Units));
        }

        private string SerializeMathMLColor(MathMLColor color)
        {
            if (color is MathMLNamedColor) return ((MathMLNamedColor)color).Name;
            else if (color is MathMLRGBColor) return ((MathMLRGBColor)color).ToString();

            return "";
        }
    }
}

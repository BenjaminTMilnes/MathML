using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class UnknownMathMLNodeException : Exception { }

    public class UnknownMathMLElementException : Exception { }

    public class MathMLSerializer
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
                var attributeValue = "";

                object defaultValue = null;

                var propertyType = property.PropertyType;

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
                        defaultValue = ((DefaultValue)propertyAttribute).Value;
                    }
                }

                if (isAttribute)
                {
                    var propertyValue = property.GetValue(element, null);

                    if (propertyType == typeof(int)) attributeValue = SerializeInteger((int)propertyValue);
                    else if (propertyType == typeof(bool)) attributeValue = SerializeBoolean((bool)propertyValue);
                    else if (propertyType == typeof(MathMLDisplay)) attributeValue = SerializeEnumeration((MathMLDisplay)propertyValue);
                    else if (propertyType == typeof(MathMLEncloseNotation)) attributeValue = SerializeEnumeration((MathMLEncloseNotation)propertyValue);
                    else if (propertyType == typeof(MathMLFractionPartAlignment)) attributeValue = SerializeEnumeration((MathMLFractionPartAlignment)propertyValue);
                    else if (propertyType == typeof(MathMLInfixLineBreakStyle)) attributeValue = SerializeEnumeration((MathMLInfixLineBreakStyle)propertyValue);
                    else if (propertyType == typeof(MathMLLabeledTableRowPlacement)) attributeValue = SerializeEnumeration((MathMLLabeledTableRowPlacement)propertyValue);
                    else if (propertyType == typeof(MathMLLineBreak)) attributeValue = SerializeEnumeration((MathMLLineBreak)propertyValue);
                    else if (propertyType == typeof(MathMLMathVariant)) attributeValue = SerializeEnumeration((MathMLMathVariant)propertyValue);
                    else if (propertyType == typeof(MathMLOperatorForm)) attributeValue = SerializeEnumeration((MathMLOperatorForm)propertyValue);
                    else if (propertyType == typeof(MathMLOverflow)) attributeValue = SerializeEnumeration((MathMLOverflow)propertyValue);
                    else if (propertyType == typeof(MathMLTableColumnAlignment)) attributeValue = SerializeEnumeration((MathMLTableColumnAlignment)propertyValue);
                    else if (propertyType == typeof(MathMLTableLineStyle)) attributeValue = SerializeEnumeration((MathMLTableLineStyle)propertyValue);
                    else if (propertyType == typeof(MathMLTableVerticalAlignment)) attributeValue = SerializeEnumeration((MathMLTableVerticalAlignment)propertyValue);
                    else if (propertyType == typeof(MathMLTextDirection)) attributeValue = SerializeEnumeration((MathMLTextDirection)propertyValue);
                    else if (propertyType == typeof(MathMLUnderOverAlignment)) attributeValue = SerializeEnumeration((MathMLUnderOverAlignment)propertyValue);
                    else if (propertyType == typeof(MathMLLength)) attributeValue = SerializeMathMLLength((MathMLLength)propertyValue);
                    else attributeValue = (string)propertyValue;

                    var defaultAttributeValue = "";

                    if (defaultValue is int) defaultAttributeValue = SerializeInteger((int)defaultValue);
                    else if (defaultValue is bool) defaultAttributeValue = SerializeBoolean((bool)defaultValue);
                    else if (defaultValue is MathMLDisplay) defaultAttributeValue = SerializeEnumeration((MathMLDisplay)defaultValue);
                    else if (defaultValue is MathMLEncloseNotation) defaultAttributeValue = SerializeEnumeration((MathMLEncloseNotation)defaultValue);
                    else if (defaultValue is MathMLFractionPartAlignment) defaultAttributeValue = SerializeEnumeration((MathMLFractionPartAlignment)defaultValue);
                    else if (defaultValue is MathMLInfixLineBreakStyle) defaultAttributeValue = SerializeEnumeration((MathMLInfixLineBreakStyle)defaultValue);
                    else if (defaultValue is MathMLLabeledTableRowPlacement) defaultAttributeValue = SerializeEnumeration((MathMLLabeledTableRowPlacement)defaultValue);
                    else if (defaultValue is MathMLLineBreak) defaultAttributeValue = SerializeEnumeration((MathMLLineBreak)defaultValue);
                    else if (defaultValue is MathMLMathVariant) defaultAttributeValue = SerializeEnumeration((MathMLMathVariant)defaultValue);
                    else if (defaultValue is MathMLOperatorForm) defaultAttributeValue = SerializeEnumeration((MathMLOperatorForm)defaultValue);
                    else if (defaultValue is MathMLOverflow) defaultAttributeValue = SerializeEnumeration((MathMLOverflow)defaultValue);
                    else if (defaultValue is MathMLTableColumnAlignment) defaultAttributeValue = SerializeEnumeration((MathMLTableColumnAlignment)defaultValue);
                    else if (defaultValue is MathMLTableLineStyle) defaultAttributeValue = SerializeEnumeration((MathMLTableLineStyle)defaultValue);
                    else if (defaultValue is MathMLTableVerticalAlignment) defaultAttributeValue = SerializeEnumeration((MathMLTableVerticalAlignment)defaultValue);
                    else if (defaultValue is MathMLTextDirection) defaultAttributeValue = SerializeEnumeration((MathMLTextDirection)defaultValue);
                    else if (defaultValue is MathMLUnderOverAlignment) defaultAttributeValue = SerializeEnumeration((MathMLUnderOverAlignment)defaultValue);
                    else if (defaultValue is MathMLLength) defaultAttributeValue = SerializeMathMLLength((MathMLLength)defaultValue);
                    else defaultAttributeValue = (string)defaultValue;

                    if (attributeValue != defaultAttributeValue)
                    {
                        attributes.Add(new Tuple<string, int, string>(attributeName, attributeOrderIndex, attributeValue));
                    }
                }
            }

            return attributes.OrderBy(a => a.Item2);
        }

        private string SerializeInteger(int value)
        {
            return value.ToString();
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
    }
}

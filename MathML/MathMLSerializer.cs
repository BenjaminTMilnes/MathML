using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathML
{
    public class UnknownMathMLElementException : Exception
    { }

    public class MathMLSerializer
    {
        public string SerializeMathMLElement(MathMLElement element)
        {
            var type = GetMathMLElementType(element);

            var elementName = GetElementName(type);
            var attributes = GetAttributes(type, element);

            var attributeString = string.Join("", attributes.Select(a => string.Format(" {0}=\"{1}\"", a.Item1, a.Item3)));

            return string.Format("<{0}{1}></{2}>", elementName, attributeString, elementName);
        }

        private Type GetMathMLElementType(MathMLElement element)
        {
            if (element is MathMLNumber)
            {
                return typeof(MathMLNumber);
            }

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

                var propertyAttributes = property.GetCustomAttributes(true);

                foreach (var propertyAttribute in propertyAttributes)
                {
                    if (propertyAttribute is MathMLAttributeName)
                    {
                        isAttribute = true;
                        attributeName = ((MathMLAttributeName)propertyAttribute).AttributeName;
                        break;
                    }
                    else if (propertyAttribute is MathMLAttributeOrderIndex)
                    {
                        attributeOrderIndex = ((MathMLAttributeOrderIndex)propertyAttribute).OrderIndex;
                    }
                }

                if (isAttribute)
                {
                    attributeValue = (string)property.GetValue(element, null);

                    if (!string.IsNullOrEmpty(attributeValue))
                    {
                        attributes.Add(new Tuple<string, int, string>(attributeName, attributeOrderIndex, attributeValue));
                    }
                }
            }

            return attributes.OrderBy(a => a.Item2);
        }
    }
}

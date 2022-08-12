using System.Xml;
using System.Xml.Serialization;

namespace NoFences.Services
{
    internal class XmlConverter
    {
        public static string Serialize(object obj)
        {
            using var writer = new StringWriter();
            using var xmlWriter = XmlWriter.Create(writer, new XmlWriterSettings { Indent = true });
            var serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(xmlWriter, obj);
            return writer.ToString();
        }

        public static T Deserialize<T>(string xml)
        {
            using var reader = new StringReader(xml);
            return Deserialize<T>(reader);
        }

        public static T Deserialize<T>(TextReader reader)
        {
            var serializer = new XmlSerializer(typeof(T));
            var deserialized = serializer.Deserialize(reader) ?? throw new InvalidOperationException("Failed to deserialize XML");
            return (T)deserialized;
        }
    }
}

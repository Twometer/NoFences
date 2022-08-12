using System.Xml.Serialization;

namespace NoFences.Services
{
    internal class XmlConverter
    {
        public static string Serialize(object obj)
        {
            using var writer = new StringWriter();
            var serializer = new XmlSerializer(obj.GetType());
            serializer.Serialize(writer, obj);
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

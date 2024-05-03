using System.Xml.Serialization;

namespace UniversalDiveDataFormat.ExtensionMethods;

public static class XmlSerializerExtensions
{
	public static T Deserialize<T>(this XmlSerializer serializer, string xml)
	{
		return (T)serializer.Deserialize(new StringReader(xml))!; // This should throw if the xml is invalid
	}
}
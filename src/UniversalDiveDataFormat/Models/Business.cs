using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("business")]
public class Business: UddfModel
{
	[XmlElement("shop")]
	public List<Shop> Shops { get; init; } = [];
}
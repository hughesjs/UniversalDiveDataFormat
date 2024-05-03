using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("shop")]
public class Shop
{
	[XmlAttribute("id")]
	public required string Id { get; init; }

	[XmlElement("name")]
	public required string Name { get; init; }

	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];

	[XmlElement("address")]
	public Address? Address { get; init; }

	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}
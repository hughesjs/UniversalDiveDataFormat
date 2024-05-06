using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("vessel")]
public class Vessel: UddfModel
{
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("marina")]
	public string? Marina { get; init; }
	
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
	
	[XmlElement("shipdimension")]
	public ShipDimension? ShipDimension { get; init; }
	
	[XmlElement("shiptype")]
	public string? ShipType { get; init; }
	
}
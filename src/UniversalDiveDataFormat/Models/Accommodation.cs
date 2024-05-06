using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("accommodation")]
public class Accommodation: UddfModel
{
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("category")]
	public AccommodationCategory? Category { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("trip")]
public class Trip: ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }

	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("trippart")]
	public List<TripPart> TripParts { get; init; } = [];
}
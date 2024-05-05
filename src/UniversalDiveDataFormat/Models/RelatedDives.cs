using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("relateddives")]
public class RelatedDives
{
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("repetitiongroup")]
	public List<RepetitionGroup> RepetitionGroups { get; init; } = [];
}
using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("relateddives")]
public class RelatedDives: UddfModel
{
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("repetitiongroup")]
	public List<RepetitionGroup> RepetitionGroups { get; init; } = [];
}
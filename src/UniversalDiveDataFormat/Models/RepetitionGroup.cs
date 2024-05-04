using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("repetitiongroup")]
public class RepetitionGroup : ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }

	[XmlElement("dive")]
	public List<Dive> Dives { get; init; } = [];
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("repetitiongroup")]
public class RepetitionGroup: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }

	[XmlElement("dive")]
	public List<Dive> Dives { get; init; } = [];
}
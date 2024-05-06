using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("generator")]
public class Generator
{
	[XmlElement("name")]
	public required string Name { get; init; }

	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];

	[XmlElement("manufacturer")]
	public Manufacturer? Manufacturer { get; init; }

	[XmlElement("version")]
	public string? Version { get; init; }

	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }

	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];

	[XmlElement("type")]
	public SourceType? SourceType { get; init; }
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("audio")]
public class Audio: ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }
	[XmlElement("objectname")]
	public required string ObjectName { get; init; }
	[XmlElement("title")]
	public string? Title { get; init; }
}
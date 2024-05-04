using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("video")]
public class Video: ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }
	[XmlElement("objectname")]
	public required string ObjectName { get; init; }
	[XmlElement("title")]
	public string? Title { get; init; }
}
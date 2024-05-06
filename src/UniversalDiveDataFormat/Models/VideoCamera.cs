using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("videocamera")]
public class VideoCamera: ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("body")]
	public Body? Body { get; init; }
	
	[XmlElement("housing")]
	public Housing? Housing { get; init; }
	
	[XmlElement("light")]
	public Light? Light { get; init; }
}
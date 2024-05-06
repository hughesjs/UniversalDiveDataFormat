using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("camera")]
public class Camera: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("body")]
	public required Body Body { get; init; }

	[XmlElement("flash")]
	public Flash? Flash { get; init; }

	[XmlElement("housing")]
	public Housing? Housing { get; init; }
	
	[XmlElement("lens")]
	public Lens? Lens { get; init; }

}
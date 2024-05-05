using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("camera")]
public class Camera: ILinkable
{
	[XmlAttribute("id")]
	public required string Id{ get; init; }
	
	[XmlElement("body")]
	public required Body Body { get; init; }

	[XmlElement("flash")]
	public Flash? Flash { get; init; }

	[XmlElement("housing")]
	public Housing? Housing { get; init; }
	
	[XmlElement("lens")]
	public Lens? Lens { get; init; }

}
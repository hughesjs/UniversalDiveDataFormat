using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("diver")]
public class Diver: UddfModel
{
	[XmlElement("owner")]
	public required Owner Owner { get; init; }
	
	[XmlElement("buddy")]
	public List<Buddy> Buddies { get; init; } = [];
}


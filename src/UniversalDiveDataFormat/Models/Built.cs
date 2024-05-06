using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("built")]
public class Built: UddfModel
{
	[XmlElement("shipyard")]
	public string? Shipyard { get; init; }
	
	[XmlElement("launchingdate")]
	public LaunchingDate? LaunchingDate { get; init; }
}
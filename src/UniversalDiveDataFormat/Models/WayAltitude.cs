using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("wayaltitude")]
public class WayAltitude: UddfModel
{
	[XmlAttribute("waytime")]
	public required float WayTimeInSeconds { get; init; }
	
	[XmlText]
	public float AltitudeInMeters { get; init; }
}
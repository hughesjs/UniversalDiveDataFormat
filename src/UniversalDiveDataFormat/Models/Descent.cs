using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("descent")]
public class Descent: UddfModel
{
	[XmlElement("waypoint")]
	public List<Waypoint> Waypoints { get; init; } = [];
}
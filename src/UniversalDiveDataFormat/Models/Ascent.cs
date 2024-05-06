using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("ascent")]
public class Ascent: UddfModel
{
	[XmlElement("waypoint")]
	public List<Waypoint> Waypoints { get; init; } = [];
}
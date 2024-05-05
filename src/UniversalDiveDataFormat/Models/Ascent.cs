using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("ascent")]
public class Ascent
{
	[XmlElement("waypoint")]
	public List<Waypoint> Waypoints { get; init; } = [];
}
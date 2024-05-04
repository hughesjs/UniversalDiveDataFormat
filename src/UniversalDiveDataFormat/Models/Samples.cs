using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("samples")]
public class Samples
{
	[XmlElement("waypoint")]
	public List<Waypoint> Waypoints { get; init; } = [];
}
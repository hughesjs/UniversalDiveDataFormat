using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("inputprofile")]
public class InputProfile
{
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("waypoint")]
	public List<Waypoint> Waypoints { get; init; } = [];
}
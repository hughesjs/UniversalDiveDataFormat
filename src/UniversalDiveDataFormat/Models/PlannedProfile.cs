using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("plannedprofile")]
public class PlannedProfile
{
	[XmlAttribute("startdivemode")]
	public required StartDiveMode StartDiveMode { get; init; }
	
	[XmlAttribute("startmix")]
	public required string StartMixId { get; init; }
	
	[XmlElement("waypoint")]
	public List<Waypoint> Waypoints { get; init; } = [];
}
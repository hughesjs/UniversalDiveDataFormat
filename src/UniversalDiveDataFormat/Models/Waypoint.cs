using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("waypoint")]
public class Waypoint: UddfModel
{
	[XmlElement("depth")]
	public float? DepthInMeters { get; init; }
	
	[XmlElement("divetime")]
	public float? DiveTimeInSeconds { get; init; }
	
	[XmlElement("switchmix")]
	public SwitchMix? SwitchMix { get; init; }
}
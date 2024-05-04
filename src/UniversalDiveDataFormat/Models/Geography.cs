using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("geography")]
public class Geography
{
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("altitude")]
	public float? AltitudeInMeters { get; init; }
	
	[XmlElement("latitude")]
	public float? LatitudeInDegreesNorth { get; init; }
	
	[XmlElement("location")]
	public string? Location { get; init; }
	
	[XmlElement("longitude")]
	public float? LongitudeInDegreesEast { get; init; }
	
	[XmlElement("timezone")]
	public decimal? TimeZoneOffsetFromUtcInHours { get; init; }
}
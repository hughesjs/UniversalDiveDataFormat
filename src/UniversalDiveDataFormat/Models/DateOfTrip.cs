using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("dateoftrip")]
public class DateOfTrip: UddfModel
{
	[XmlAttribute("startdate")]
	public required DateTime StartDate { get; init; }
	
	[XmlAttribute("enddate")]
	public required DateTime EndDate { get; init; }
}
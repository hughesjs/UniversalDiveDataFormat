using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("numberofdives")]
public class NumberOfDives: UddfModel
{
	[XmlAttribute("dives")]
	public required int Dives { get; init; }
	
	[XmlAttribute("startdate")]
	public required DateTime StartDate { get; init; }
	
	[XmlAttribute("enddate")]
	public required DateTime EndDate { get; init; }
}
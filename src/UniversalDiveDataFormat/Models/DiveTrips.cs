using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divetrip")]
public class DiveTrips: UddfModel
{
	[XmlElement("trip")]
	public List<Trip> Trips { get; init; } = [];
}
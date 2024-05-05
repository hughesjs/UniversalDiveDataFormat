using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divetrip")]
public class DiveTrips
{
	[XmlElement("trip")]
	public List<Trip> Trips { get; init; } = [];
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("dateofflight")]
public class DateOfFlight: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
}
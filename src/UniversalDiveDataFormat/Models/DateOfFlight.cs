using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("dateofflight")]
public class DateOfFlight
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
}
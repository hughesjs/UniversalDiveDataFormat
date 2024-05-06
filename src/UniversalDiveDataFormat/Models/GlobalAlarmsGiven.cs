using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("globalalarmsgiven")]
public class GlobalAlarmsGiven: UddfModel
{
	[XmlElement("globalalarm")]
	public List<GlobalAlarm> GlobalAlarms { get; init; } = [];
}
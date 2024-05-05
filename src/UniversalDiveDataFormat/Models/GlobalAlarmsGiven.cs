using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("globalalarmsgiven")]
public class GlobalAlarmsGiven
{
	[XmlElement("globalalarm")]
	public List<GlobalAlarm> GlobalAlarms { get; init; } = [];
}
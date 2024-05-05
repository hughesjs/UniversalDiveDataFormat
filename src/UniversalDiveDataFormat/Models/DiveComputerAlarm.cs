using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("dcalarm")]
public class DiveComputerAlarm
{
	[XmlElement("acknowledge")]
	public Acknowledge? Acknowledge { get; init; }
	
	[XmlElement("alarmtype")]
	public int AlarmType { get; init; }
	
	[XmlElement("period")]
	public float? PeriodInSeconds { get; init; }
}
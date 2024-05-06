using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcalarmtime")]
public class SetDiveComputerAlarmTime: UddfModel
{
	[XmlElement("datetime")]
	public required DateTime DateTime { get; init; }
	
	[XmlElement("dcalarm")]
	public required DiveComputerAlarm DiveComputerAlarm { get; init; }
}
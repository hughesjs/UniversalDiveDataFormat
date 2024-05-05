using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcalarmtime")]
public class SetDiveComputerAlarmTime
{
	[XmlElement("datetime")]
	public DateTime DateTime { get; init; }
	
	[XmlElement("dcalarm")]
	public DiveComputerAlarm DiveComputerAlarm { get; init; }
}
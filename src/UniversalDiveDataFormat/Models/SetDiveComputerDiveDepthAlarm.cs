using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivedepthalarm")]
public class SetDiveComputerDiveDepthAlarm
{
	[XmlElement("dcalarm")]
	public required DiveComputerAlarm DiveComputerAlarm { get; init; }
	
	[XmlElement("dcalarmdepth")]
	public required float DiveComputerAlarmDepthInMeters { get; init; }
}
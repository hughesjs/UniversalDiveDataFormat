using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcendndtalarm")]
public class SetDiveComputerEndNoDecoTimeAlarm: UddfModel
{
	[XmlElement("dcalarm")]
	public required DiveComputerAlarm DiveComputerAlarm { get; init; }
}
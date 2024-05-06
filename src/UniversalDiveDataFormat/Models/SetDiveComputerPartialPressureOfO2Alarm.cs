using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivepo2alarm")]
public class SetDiveComputerPartialPressureOfO2Alarm: UddfModel
{
	[XmlElement("dcalarm")]
	public required DiveComputerAlarm DiveComputerAlarm { get; init; }
	
	[XmlElement("maximumpo2")]
	public required float MaximumPartialPressureOfO2InBars { get; init; }
}
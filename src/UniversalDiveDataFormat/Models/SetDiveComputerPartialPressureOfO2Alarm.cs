using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivepo2alarm")]
public class SetDiveComputerPartialPressureOfO2Alarm
{
	[XmlElement("dcalarm")]
	public DiveComputerAlarm DiveComputerAlarm { get; init; }
	
	[XmlElement("maximumpo2")]
	public float? MaximumPartialPressureOfO2InBars { get; init; }
}
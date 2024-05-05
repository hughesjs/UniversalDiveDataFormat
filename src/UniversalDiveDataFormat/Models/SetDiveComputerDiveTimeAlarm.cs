using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivetimealarm")]
public class SetDiveComputerDiveTimeAlarm
{
	[XmlElement("dcalarm")]
	public required DiveComputerAlarm DiveComputerAlarm { get; init; }
	
	[XmlElement("timespan")]
	public required float TimeSpanInSeconds { get; init; }
}
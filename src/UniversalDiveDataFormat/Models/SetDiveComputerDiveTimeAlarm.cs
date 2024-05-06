using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivetimealarm")]
public class SetDiveComputerDiveTimeAlarm: UddfModel
{
	[XmlElement("dcalarm")]
	public required DiveComputerAlarm DiveComputerAlarm { get; init; }
	
	[XmlElement("timespan")]
	public required float TimeSpanInSeconds { get; init; }
}
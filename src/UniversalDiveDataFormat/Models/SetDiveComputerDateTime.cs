using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdatetime")]
public class SetDiveComputerDateTime: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("dcalarm")]
	public DiveComputerAlarm? DiveComputerAlarm { get; init; }
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcbuddydata")]
public class SetDiveComputerBuddyData: UddfModel
{
	[XmlAttribute("buddy")]
	public required string BuddyId { get; init; }
}
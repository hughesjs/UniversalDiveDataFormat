using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivesitedata")]
public class SetDiveComputerDiveSiteData: UddfModel
{
	[XmlAttribute("divesite")]
	public required string DiveSiteId { get; init; }
}
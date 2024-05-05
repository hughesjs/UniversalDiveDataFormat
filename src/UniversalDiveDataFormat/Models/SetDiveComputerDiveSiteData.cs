using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdivesitedata")]
public class SetDiveComputerDiveSiteData
{
	[XmlAttribute("divesite")]
	public string DiveSiteId { get; init; }
}
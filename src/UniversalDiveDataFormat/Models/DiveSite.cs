using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divesite")]
public class DiveSite: UddfModel
{
	[XmlElement("site")]
	public List<Site> Sites { get; init; } = [];
	
	[XmlElement("divebase")]
	public List<DiveBase> DiveBases { get; init; } = [];
}
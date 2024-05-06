using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("diveinsurances")]
public class DiveInsurances: UddfModel
{
	[XmlElement("insurance")]
	public List<Insurance> Insurances { get; init; } = [];
}
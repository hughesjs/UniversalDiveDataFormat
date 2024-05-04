using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("diveinsurances")]
public class DiveInsurances
{
	[XmlElement("insurance")]
	public List<Insurance> Insurances { get; init; } = [];
}
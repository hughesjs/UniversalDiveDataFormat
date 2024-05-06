using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("calculateprofile")]
public class CalculateProfile: UddfModel
{
	[XmlElement("profile")]
	public List<Profile> Profiles { get; init; } = [];
}
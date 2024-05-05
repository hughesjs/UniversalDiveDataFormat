using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("calculateprofile")]
public class CalculateProfile
{
	[XmlElement("profile")]
	public List<Profile> Profiles { get; init; } = [];
}
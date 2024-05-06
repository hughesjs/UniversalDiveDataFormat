using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("profiledata")]
public class ProfileData: UddfModel
{
	[XmlElement("repetitiongroup")]
	public List<RepetitionGroup> RepetitionGroups { get; init; } = [];
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("profiledata")]
public class ProfileData
{
	[XmlElement("repetitiongroup")]
	public List<RepetitionGroup> RepetitionGroups { get; init; } = [];
}
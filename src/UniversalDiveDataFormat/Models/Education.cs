using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("education")]
public class Education: UddfModel
{
	[XmlElement("certification")]
	public required List<Certification> Certifications { get; init; }
}
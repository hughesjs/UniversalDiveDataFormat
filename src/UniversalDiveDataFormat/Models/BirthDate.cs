using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("birthdate")]
public class BirthDate
{
	[XmlElement("datetime")]
	public required DateTime DateTime { get; init; }
}
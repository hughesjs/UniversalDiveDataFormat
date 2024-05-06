using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("validdate")]
public class ValidDate: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
}
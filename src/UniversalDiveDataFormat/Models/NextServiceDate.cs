using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("nextservicedate")]
public class NextServiceDate: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
}
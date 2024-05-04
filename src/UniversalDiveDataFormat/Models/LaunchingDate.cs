using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("LaunchingDate")]
public class LaunchingDate
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
}
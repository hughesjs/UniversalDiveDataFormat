using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("launchingdate")]
public class LaunchingDate
{
	[XmlElement("datetime")]
	public DateTime DateTime { get; init; }
}
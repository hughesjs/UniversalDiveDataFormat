using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("switchmix")]
public class SwitchMix: UddfModel
{
	[XmlAttribute("ref")]
	public required string Ref { get; init; }
}
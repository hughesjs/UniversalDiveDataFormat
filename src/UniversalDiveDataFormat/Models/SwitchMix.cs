using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("switchmix")]
public class SwitchMix
{
	[XmlAttribute("ref")]
	public required string Ref { get; init; }
}
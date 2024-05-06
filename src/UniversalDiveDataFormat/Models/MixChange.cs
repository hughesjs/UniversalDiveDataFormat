using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("mixchange")]
public class MixChange: UddfModel
{
	[XmlElement("ascent")]
	public required Ascent Ascent { get; init; }
	
	[XmlElement("descent")]
	public Descent? Descent { get; init; }
}
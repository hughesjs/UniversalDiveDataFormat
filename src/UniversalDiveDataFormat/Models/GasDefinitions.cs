using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("gasdefinitions")]
public class GasDefinitions: UddfModel
{
	[XmlElement("mix")]
	public List<Mix> Mixes { get; init; } = [];
}
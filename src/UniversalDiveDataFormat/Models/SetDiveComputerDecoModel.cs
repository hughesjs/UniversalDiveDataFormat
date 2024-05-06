using System.Xml;
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdecomodel")]
public class SetDiveComputerDecoModel: UddfModel
{
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];

	[XmlElement("applicationdata")]
	public XmlElement? ApplicationData { get; init; } // This stuff is application-specific
}
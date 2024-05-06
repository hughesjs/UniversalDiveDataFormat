using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("rgbm")]
public class Rgbm: ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("tissue")]
	public List<Tissue> Tissues { get; init; } = [];
}
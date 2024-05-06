using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("buehlmann")]
public class Buehlmann: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }

	[XmlElement("gradientfactorhigh")]
	public float? GradientFactorHigh { get; init; }
	
	[XmlElement("gradientfactorlow")]
	public float? GradientFactorLow { get; init; }
	
	[XmlElement("tissue")]
	public List<Tissue> Tissues { get; init; } = [];
}
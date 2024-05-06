using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("vpm")]
public class Vpm: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }

	[XmlElement("conservatism")]
	public float? Conservatism { get; init; }
	
	[XmlElement("gamma")]
	public float? Gamma { get; init; }
	
	[XmlElement("gc")]
	public float? Gc { get; init; }
	
	[XmlElement("lambda")]
	public float? Lambda { get; init; }
	
	[XmlElement("r0")]
	public float? R0 { get; init; }
	
	[XmlElement("tissue")]
	public List<Tissue> Tissues { get; init; } = [];
}
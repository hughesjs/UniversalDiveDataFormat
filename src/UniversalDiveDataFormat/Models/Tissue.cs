using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("tissue")]
public class Tissue
{
	[XmlAttribute("gas")]
	public required Gas Gas { get; init; } 
	
	[XmlAttribute("halflife")]
	public float HalfLifeInSeconds { get; init; }
	
	[XmlAttribute("number")]
	public int Number { get; init; }
	
	[XmlAttribute("a")]
	public float A { get; init; }
	
	[XmlAttribute("b")]
	public float B { get; init; }
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("species")]
public class Species : ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }

	[XmlElement("trivialname")]
	public string? TrivialName { get; init; }

	[XmlElement("scientificname")]
	public string? ScientificName { get; init; }
	
	[XmlElement("abundance")]
	public Abundance? Abundance { get; init; }
	
	[XmlElement("age")]
	public int? AgeInYears { get; init; }
	
	[XmlElement("dominance")]
	public Dominance? Dominance { get; init; }
	
	[XmlElement("lifestage")]
	public LifeStage? LifeStage { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("sex")]
	public Sex? Sex { get; init; }
	
	[XmlElement("size")]
	public float? SizeInMeters { get; init; }

}
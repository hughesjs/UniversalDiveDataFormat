using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("flora")]
public class Flora
{
	[XmlElement("chlorophyceae")]
	public List<Chlorophyceae> Chlorophyceae { get; init; } = [];
	
	[XmlElement("floravarious")]
	public List<Floravarious> FloraVarious { get; init; } = [];
	
	[XmlElement("phaeophyceae")]
	public List<Phaeophyceae> Phaeophyceae { get; init; } = [];
	
	[XmlElement("rhodophyceae")]
	public List<Rhodophyceae> Rhodophyceae { get; init; } = [];
	
	[XmlElement("spermatophyta")]
	public List<Spermatophyta> Spermatophyta { get; init; } = [];
	
	[XmlElement("notes")]
	public string? Notes { get; init; }
}
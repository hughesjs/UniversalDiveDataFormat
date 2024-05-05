
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("invertebrata")]
public class Invertebrata
{
	[XmlElement("amphibia")]
	public Amphibia? Amphibia { get; init; }
	
	[XmlElement("chondrichthyes")]
	public Chondrichthyes? Chondrichthyes { get; init; }
	
	[XmlElement("mammalia")]
	public Mammalia? Mammalia { get; init; }
	
	[XmlElement("osteichthyes")]
	public Osteichthyes? Osteichthyes { get; init; }
	
	[XmlElement("reptilia")]
	public Reptilia? Reptilia { get; init; }
	
	[XmlElement("vertebratavarious")]
	public VertebrataVarious? VertebrataVarious { get; init; }
}
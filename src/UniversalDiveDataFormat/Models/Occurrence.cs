using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("occurrence")]
public enum Occurrence
{
	[XmlEnum("unknown")]
	Unknown,
	
	[XmlEnum("not-ascertainable")]
	NotAscertainable,
	
	[XmlEnum("single-individual")]
	SingleIndividual,
	
	[XmlEnum("loose-association")]
	LooseAssociation,
	
	[XmlEnum("swarm")]
	Swarm,
	
	[XmlEnum("colony")]
	Colony
}
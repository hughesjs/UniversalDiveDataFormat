using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("lifestage")]
public enum LifeStage
{
	[XmlEnum("larva")]
	Larva,
	
	[XmlEnum("juvenile")]
	Juvenile,
	
	[XmlEnum("adult")]
	Adult
}
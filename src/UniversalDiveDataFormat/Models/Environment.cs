using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("environment")]
public enum Environment
{
	[XmlEnum("unknown")]
	Unknown,
	
	[XmlEnum("ocean-sea")]
	OceanSea,
	
	[XmlEnum("lake-quarry")]
	LakeQuarry,
	
	[XmlEnum("river-spring")]
	RiverSpring,
	
	[XmlEnum("cave-cavern")]
	CaveCavern,
	
	[XmlEnum("pool")]
	Pool,
	
	[XmlEnum("hyperbaric-chamber")]
	HyperbaricChamber,
	
	[XmlEnum("under-ice")]
	UnderIce,
	
	[XmlEnum("other")]
	Other
}
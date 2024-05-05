using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divetable")]
public enum DiveTable
{
	[XmlEnum("other")]
	Other,
	
	[XmlEnum("PADI")]
	Padi,
	
	[XmlEnum("NAUI")]
	Naui,
	
	[XmlEnum("BSAC")]
	Bsac,
	
	[XmlEnum("Buehlmann")]
	Buehlmann,
	
	[XmlEnum("DCIEM")]
	Dciem,
	
	[XmlEnum("US-Navy")]
	UsNavy,
	
	[XmlEnum("CSMD")]
	Csmd,
	
	[XmlEnum("COMEX")]
	Comex,
}
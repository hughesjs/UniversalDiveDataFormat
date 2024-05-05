using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("apparatus")]
public enum Apparatus
{
	[XmlEnum("other")]
	Other,
	
	[XmlEnum("open-scuba")]
	OpenScuba,
	
	[XmlEnum("rebreather")]
	Rebreather,
	
	[XmlEnum("surface-supplied")]
	SurfaceSupplied,
	
	[XmlEnum("chamber")]
	Chamber,
	
	[XmlEnum("experimental")]
	Experimental,
}
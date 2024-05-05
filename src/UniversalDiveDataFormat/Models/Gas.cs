using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("gas")]
public enum Gas
{
	[XmlEnum("h2")]
	Hydrogen,
	
	[XmlEnum("he")]
	Helium,
	
	[XmlEnum("n2")]
	Nitrogen,
	
	[XmlEnum("o2")]
	Oxygen,
	
	[XmlEnum("ar")]
	Argon
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("sex")]
public enum Sex
{
	[XmlEnum("undetermined")]
	Undetermined,
	
	[XmlEnum("male")]
	Male,
	
	[XmlEnum("female")]
	Female,
	
	[XmlEnum("hermaphrodite")]
	Hermaphrodite
}
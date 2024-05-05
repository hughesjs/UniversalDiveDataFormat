using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("quality")]
public enum Quality
{
	[XmlEnum("unknown")]
	Unknown,
	
	[XmlEnum("exact")]
	Exact,
	
	[XmlEnum("estimated")]
	Estimated
}
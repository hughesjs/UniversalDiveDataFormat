using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("workload")]
public enum WorkloadType
{
	
	[XmlEnum("not-specified")]
	NotSpecified,
	[XmlEnum("resting")]
	Resting,
	[XmlEnum("light")]
	Light,
	[XmlEnum("moderate")]
	Moderate,
	[XmlEnum("severe")]
	Severe,
	[XmlEnum("exhausting")]
	Exhausting		
}
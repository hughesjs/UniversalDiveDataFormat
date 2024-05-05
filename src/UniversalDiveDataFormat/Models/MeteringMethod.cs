using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("meteringmethod")]
public enum MeteringMethod
{
	[XmlEnum("unknown")]
	Unknown,
	[XmlEnum("spot")]
	Spot,
	[XmlEnum("centerweighted")]
	CentreWeighted,
	[XmlEnum("matrix")]
	Matrix,
}
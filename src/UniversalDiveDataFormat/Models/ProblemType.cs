using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("problems")]
public enum ProblemType
{
	[XmlEnum("none")]
	None,

	[XmlEnum("equalisation")]
	Equalisation,

	[XmlEnum("vertigo")]
	Vertigo,

	[XmlEnum("out-of-air")]
	OutOfAir,

	[XmlEnum("buoyancy")]
	Buoyancy,

	[XmlEnum("shared-air")]
	SharedAir,

	[XmlEnum("rapid-ascent")]
	RapidAscent,

	[XmlEnum("sea-sickness")]
	SeaSickness,

	[XmlEnum("other")]
	Other
}
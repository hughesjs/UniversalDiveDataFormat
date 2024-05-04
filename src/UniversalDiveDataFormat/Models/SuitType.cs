using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("suittype")]
public enum SuitType
{
	[XmlEnum("dive-skin")]
	DiveSkin,

	[XmlEnum("wet-suit")]
	WetSuit,

	[XmlEnum("dry-suit")]
	DrySuit,

	[XmlEnum("hot-water-suit")]
	HotWaterSuit,

	[XmlEnum("other")]
	Other
}
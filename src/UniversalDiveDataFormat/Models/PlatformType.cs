using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("platform")]
public enum PlatformType
{
	[XmlEnum("other")]
	Other,

	[XmlEnum("beach-shore")]
	BeachShore,

	[XmlEnum("pier")]
	Pier,

	[XmlEnum("small-boat")]
	SmallBoat,

	[XmlEnum("charter-boat")]
	CharterBoat,

	[XmlEnum("live-aboard")]
	LiveAboard,

	[XmlEnum("barge")]
	Barge,

	[XmlEnum("landside")]
	Landside,

	[XmlEnum("hyperbaric-facility")]
	HyperbaricFacility,
}
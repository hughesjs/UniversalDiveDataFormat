using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("purpose")]
public enum PurposeType
{
	[XmlEnum("other")]
	Other,

	[XmlEnum("sightseeing")]
	Sightseeing,

	[XmlEnum("learning")]
	Learning,

	[XmlEnum("teaching")]
	Teaching,

	[XmlEnum("research")]
	Research,

	[XmlEnum("photography-videography")]
	PhotographyVideography,

	[XmlEnum("spearfishing")]
	Spearfishing,

	[XmlEnum("proficiency")]
	Proficiency,

	[XmlEnum("work")]
	Work

}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("category")]
public enum AccommodationCategory
{
	[XmlEnum("other")]
	Other,
	[XmlEnum("hotel")]
	Hotel,
	[XmlEnum("camping")]
	Camping
}
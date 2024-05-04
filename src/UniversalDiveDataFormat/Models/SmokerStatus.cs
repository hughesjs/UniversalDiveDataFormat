using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("smoker")]
public enum SmokerStatus
{
	[XmlEnum("0")]
	NonSmoker,
	[XmlEnum("0-3")]
	ZeroToThreePerDay,
	[XmlEnum("4-10")]
	FourToTenPerDay,
	[XmlEnum("11-20")]
	ElevenToTwentyPerDay, 
	[XmlEnum("21-40")]
	TwentyOneToFortyPerDay, 
	[XmlEnum("40+")]
	FortyPlusPerDay
}
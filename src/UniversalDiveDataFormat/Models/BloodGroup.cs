using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("bloodgroup")]
public enum BloodGroup
{
	[XmlEnum("A+")]
	APositive,

	[XmlEnum("A-")]
	ANegative,

	[XmlEnum("B+")]
	BPositive,

	[XmlEnum("B-")]
	BNegative,

	[XmlEnum("AB+")]
	ABPositive,

	[XmlEnum("AB-")]
	ABNegative,

	[XmlEnum("O+")]
	OPositive,

	[XmlEnum("O-")]
	ONegative,

	[XmlEnum("A")]
	A,

	[XmlEnum("B")]
	B,

	[XmlEnum("AB")]
	AB,

	[XmlEnum("O")]
	O
}
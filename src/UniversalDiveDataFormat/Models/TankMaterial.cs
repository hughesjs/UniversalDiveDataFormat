using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("tankmaterial")]
public enum TankMaterial
{
	[XmlEnum("steel")]
	Steel,

	[XmlEnum("aluminium")]
	Aluminium,

	[XmlEnum("carbon")]
	Carbon
}
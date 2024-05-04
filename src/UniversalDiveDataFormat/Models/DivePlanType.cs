using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("diveplan")]
public enum DivePlanType
{
	[XmlEnum("none")]
	None,
	
	[XmlEnum("table")]
	Table,
	
	[XmlEnum("dive-computer")]
	DiveComputer,
	
	[XmlEnum("another-diver")]
	AnotherDiver
}
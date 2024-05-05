using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("current")]
public enum Current
{
	[XmlEnum("no-current")]
	NoCurrent,
	
	[XmlEnum("very-mild-current")]
	VeryMildCurrent,
	
	[XmlEnum("mild-current")]
	MildCurrent,
	
	[XmlEnum("moderate-current")]
	ModerateCurrent,
	
	[XmlEnum("hard-current")]
	HardCurrent,
	
	[XmlEnum("very-hard-current")]
	VeryHardCurrent
}
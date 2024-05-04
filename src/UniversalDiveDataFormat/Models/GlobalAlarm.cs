using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("globalalarm")]
public enum GlobalAlarm
{
	[XmlEnum("sos-mode")]
	SosMode,
	
	[XmlEnum("work-too-hard")]
	WorkTooHard,
	
	[XmlEnum("ascent-warning-too-long")]
	AscentWarningTooLong
}
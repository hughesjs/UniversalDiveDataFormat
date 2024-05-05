using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("stateofrestbeforedive")]
public enum StateOfRestBeforeDive
{
	[XmlEnum("not-specified")]
	NotSpecified,
	
	[XmlEnum("rested")]
	Rested,
	
	[XmlEnum("tired")]
	Tired,
	
	[XmlEnum("exhausted")]
	Exhausted
}
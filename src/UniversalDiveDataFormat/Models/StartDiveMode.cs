using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("startdivemode")]
public enum StartDiveMode
{
	[XmlEnum("unknown")]
	Unknown,
	
	[XmlEnum("apnoe")]
	Apnoe,
	[XmlEnum("closedcircuit")]
	ClosedCircuit,
	[XmlEnum("opencircuit")]
	OpenCircuit,
	[XmlEnum("semiclosedcircuit")]
	SemiClosedCircuit
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("transportation")]
public enum TransportationType
{
	[XmlEnum("unknown")]
	Unknown,
	[XmlEnum("commercial-aircraft")]
	CommercialAircraft,
	
	[XmlEnum("unpressurized-aircraft")]
	UnpressurizedAircraft,
	
	[XmlEnum("medevac-aircraft")]
	MedevacAircraft,
	
	[XmlEnum("ground-transportation")]
	GroundTransportation,
	
	[XmlEnum("helicopter")]
	Helicopter
}
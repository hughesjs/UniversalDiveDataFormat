using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("shipdimension")]
public class ShipDimension
{
	[XmlElement("beam")]
	public float? BeamInMeters { get; init; }
	
	[XmlElement("displacement")]
	public float? DisplacementInKilograms { get; init; }
	
	[XmlElement("draught")]
	public float? DraughtInMeters { get; init; }
	
	[XmlElement("length")] 
	public float? LengthInMeters { get; init; }
	
	[XmlElement("tonnage")]
	public float? TonnageInKilograms { get; init; }
}
using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("informationbeforedive")]
public class InformationBeforeDive
{
	[XmlElement("airtemperature")]
	public float? AirTemperatureInKelvin { get; init; }
	
	[XmlElement("alcoholbeforedive")]
	public AlcoholBeforeDive? AlcoholBeforeDive { get; init; }
	
	[XmlElement("altitude")]
	public float? AltitudeInMeters { get; init; }
	
	[XmlElement("apparatus")]
	public Apparatus? Apparatus { get; init; }
	
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("divenumber")]
	public string? DiveNumber { get; init; }
	
	[XmlElement("divenumberofday")]
	public int? DiveNumberOfDay { get; init; }
	
	[XmlElement("internaldivenumber")]
	public string? InternalDiveNumber { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("medicationbeforedive")]
	public MedicationBeforeDive? MedicationBeforeDive { get; init; }
	
	[XmlElement("nosuit")]
	public NoSuit? NoSuit { get; init; }
	
	[XmlElement("plannedprofile")]
	public PlannedProfile? PlannedProfile { get; init; }
	
	[XmlElement("platform")]
	public PlatformType? Platform { get; init; }
	
	[XmlElement("price")]
	public Price? Price { get; init; }
	
	[XmlElement("purpose")]
	public PurposeType? Purpose { get; init; }
	
	[XmlElement("stateofrestbeforedive")]
	public StateOfRestBeforeDive? StateOfRestBeforeDive { get; init; }
	
	[XmlElement("surfaceintervalbeforedive")]
	public SurfaceIntervalBeforeDive? SurfaceIntervalBeforeDive { get; init; }
	
	[XmlElement("surfacepressure")]
	public float? SurfacePressureInPascal { get; init; }
	
	[XmlElement("tripmembership")]
	public string? TripMembership { get; init; }
}
using System.Xml;
using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("profile")]
public class Profile: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("applicationdata")]
	public XmlElement? ApplicationData { get; init; } // This stuff is application-specific
	
	[XmlElement("decomodel")]
	public DecoModel? DecoModel { get; init; }
	
	[XmlElement("deepstoptime")]
	public  float? DeepStopTimeInSeconds { get; init; }
	
	[XmlElement("density")]
	public  float? DensityInKgPerMeterCubed { get; init; }
	
	[XmlElement("inputprofile")]
	public required InputProfile? InputProfile { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("maximumascendingrate")]
	public required float MaximumAscendingRateInCubicMetersPerSecond { get; init; }
	
	[XmlElement("mixchange")]
	public required MixChange MixChange { get; init; }
	
	[XmlElement("output")]
	public Output? Output { get; init; }
	
	[XmlElement("surfaceintervalafterdive")]
	public SurfaceIntervalAfterDive? SurfaceIntervalAfterDive { get; init; }
	
	[XmlElement("surfaceintervalbeforedive")]
	public SurfaceIntervalBeforeDive? SurfaceIntervalBeforeDive { get; init; }
	
	[XmlElement("title")]
	public string? Title { get; init; }
	
}
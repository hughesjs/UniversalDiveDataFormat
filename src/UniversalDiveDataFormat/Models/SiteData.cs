using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("sitedata")]
public class SiteData: UddfModel
{
	[XmlElement("arealength")]
	public float? AreaLengthInMeters { get; init; }
	
	[XmlElement("areawidth")]
	public float? AreaWidthInMeters { get; init; }
	
	[XmlElement("averagevisibility")]
	public float? AverageVisibilityInMeters { get; init; }
	
	[XmlElement("bottom")]
	public string? Bottom { get; init; }
	
	[XmlElement("cave")]
	public Cave? Cave { get; init; } 
	
	[XmlElement("density")]
	public float? DensityInKgPerMeterCubed { get; init; }
	
	[XmlElement("difficulty")]
	public int? Difficulty { get; init; }
	
	[XmlElement("globallightintensity")]
	public GlobalLightIntensity? GlobalLightIntensity { get; init; }
	
	[XmlElement("indoor")]
	public Indoor? Indoor { get; init; }
	
	[XmlElement("lake")]
	public Lake? Lake { get; init; }
	
	[XmlElement("maximumdepth")]
	public float? MaximumDepthInMeters { get; init; }
	
	[XmlElement("maximumvisibility")]
	public float? MaximumVisibilityInMeters { get; init; }
	
	[XmlElement("minimumdepth")]
	public float? MinimumDepthInMeters { get; init; }
	
	[XmlElement("minimumvisibility")]
	public float? MinimumVisibilityInMeters { get; init; }
	
	[XmlElement("river")]
	public River? River { get; init; }
	
	[XmlElement("shore")]
	public Shore? Shore { get; init; }
	
	[XmlElement("terrain")]
	public string? Terrain { get; init; }
	
	[XmlElement("wreck")]
	public Wreck? Wreck { get; init; }
}

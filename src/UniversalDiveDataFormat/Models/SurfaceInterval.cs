using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public abstract class SurfaceInterval
{
	[XmlElement("exposuretoaltitude")]
	public ExposureToAltitude? ExposureToAltitude { get; init; }
	
	[XmlElement("infinity")]
	public Infinity? Infinity { get; init; }
	
	[XmlElement("passedtime")]
	public float? PassedTimeInSeconds { get; init; }
	
	[XmlElement("wayaltitude")]
	public List<WayAltitude> WayAltitudes { get; init; } = [];
}


[XmlRoot("surfaceintervalafterdive")]
public class SurfaceIntervalAfterDive: SurfaceInterval;

[XmlRoot("surfaceintervalbeforedive")]
public class SurfaceIntervalBeforeDive: SurfaceInterval;
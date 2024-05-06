using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("exposuretoaltitude")]
public class ExposureToAltitude: UddfModel
{
	
	[XmlElement("altitudeofexposure")]
	public float? AltitudeOfExposureInMeters { get; init; }
	
	[XmlElement("dateofflight")]
	public DateOfFlight? DateOfFlight { get; init; }
	
	[XmlElement("surfaceintervalbeforealtitudeexposure")]
	public float? SurfaceIntervalBeforeAltitudeExposureInSeconds { get; init; }
	
	[XmlElement("totallengthofexposure")]
	public float? TotalLengthOfExposureInSeconds { get; init; }
	
	[XmlElement("transportation")]
	public TransportationType? Transportation { get; init; }
}
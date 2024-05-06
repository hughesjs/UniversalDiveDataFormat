using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("imagedata")]
public class ImageData: UddfModel
{
	[XmlElement("aperture")]
	public float? Aperture { get; init; }
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	[XmlElement("exposurecompensation")]
	public float? Exposure { get; init; }
	[XmlElement("filmspeed")]
	public int? FilmSpeed { get; init; }
	[XmlElement("focallength")]
	public float? FocalLengthInMeters { get; init; }
	[XmlElement("focusingdistance")]
	public float? FocussingDistanceInMeters { get; init; }
	[XmlElement("meteringmethod")]
	public MeteringMethod? MeteringMethod { get; init; }
	[XmlElement("shutterspeed")]
	public float? ShutterSpeedInSeconds { get; init; }
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("tablescope")]
public class TableScope
{
	[XmlElement("altitude")]
	public required float AltitudeInMeters { get; init; }
	
	[XmlElement("bottomtimemaximum")]
	public required float BottomTimeMaximumInSeconds { get; init; }
	
	[XmlElement("bottomtimeminimum")]
	public required float BottomTimeMinimumInSeconds { get; init; }
	
	[XmlElement("bottomtimestepbegin")]
	public required float BottomTimeStepBeginInSeconds { get; init; }
	
	[XmlElement("bottomtimestepend")]
	public required float BottomTimeStepEndInSeconds { get; init; }
	
	[XmlElement("divedepthbegin")]
	public required float DiveDepthBeginInMeters { get; init; }
	
	[XmlElement("divedepthend")]
	public required float DiveDepthEndInMeters { get; init; }
	
	[XmlElement("divedepthstep")]
	public required float DiveDepthStepInMeters { get; init; }
}
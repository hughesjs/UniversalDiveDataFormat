using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("bottomtimetablescope")]
public class BottomTimeTableScope
{
	[XmlElement("breathingconsumptionvolumebegin")]
	public required float BreathingConsumptionVolumeBeginInCubicMetersPerSecond { get; init; }
	
	[XmlElement("breathingconsumptionvolumeend")]
	public required float BreathingConsumptionVolumeEndInCubicMetersPerSecond { get; init; }
	
	[XmlElement("breathingconsumptionvolumestep")]
	public required float BreathingConsumptionVolumeStepInCubicMetersPerSecond { get; init; }
	
	[XmlElement("divedepthbegin")]
	public required float DiveDepthBeginInMeters { get; init; }
	
	[XmlElement("divedepthend")]
	public required float DiveDepthEndInMeters { get; init; }
	
	[XmlElement("divedepthstep")]
	public required float DiveDepthStepInMeters { get; init; }
	
	[XmlElement("tankpressurebegin")]
	public required float TankPressureBeginInPascal{ get; init; }
	
	[XmlElement("tankpressurereserve")]
	public required float TankPressureReserveInPascal { get; init; }
	
	[XmlElement("tankvolumebegin")]
	public required float TankVolumeBeginInCubicMeters { get; init; }
	
	[XmlElement("tankvolumeend")]
	public required float TankVolumeEndInCubicMeters { get; init; }
	
	[XmlElement("tankvolumestep")]
	public required float TankVolumeStepInCubicMeters { get; init; }
	
	
}
using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("tankdata")]
public class TankData: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }

	[XmlElement("breathingconsumptionvolume")]
	public float? BreathingConsumptionVolumeInMetersCubedPerSecond { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("tankpressurebegin")]
	public float? TankPressureBeginInPascals{ get; init; }
	
	[XmlElement("tankpressureend")]
	public float? TankPressureEndInPascals { get; init; }
	
	[XmlElement("tankvolume")]
	public float? TankVolumeInMetersCubed { get; init; }
}
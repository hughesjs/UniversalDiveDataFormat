using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("equipmentused")]
public class EquipmentUsed: UddfModel
{
	[XmlElement("leadquantity")]
	public float? LeadQuantityInKg { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("boots")]
	public List<Boots> Boots { get; init; } = [];
	
	[XmlElement("buoyancycontroldevice")]
	public List<BuoyancyControlDevice> BuoyancyControlDevices { get; init; } = [];
	
	[XmlElement("camera")]
	public List<Camera> Cameras { get; init; } = [];
	
	[XmlElement("compass")]
	public List<Compass> Compasses { get; init; } = [];
	
	[XmlElement("divecomputer")]
	public List<DiveComputer> DiveComputers { get; init; } = [];
	
	[XmlElement("equipmentconfiguration")]
	public List<EquipmentConfiguration> EquipmentConfigurations { get; init; } = [];
	
	[XmlElement("fins")]
	public List<Fins> Fins { get; init; } = [];
	
	[XmlElement("gloves")]
	public List<Gloves> Gloves { get; init; } = [];
	
	[XmlElement("knife")]
	public List<Knife> Knives { get; init; } = [];
	
	[XmlElement("lead")]
	public List<Lead> Lead { get; init; } = [];
	
	[XmlElement("light")]
	public List<Light> Lights { get; init; } = [];
	
	[XmlElement("mask")]
	public List<Mask> Masks { get; init; } = [];
	
	[XmlElement("rebreather")]
	public List<Rebreather> Rebreathers { get; init; } = [];
	
	[XmlElement("regulator")]
	public List<Regulator> Regulators { get; init; } = [];
	
	[XmlElement("scooter")]
	public List<Scooter> Scooters { get; init; } = [];
	
	[XmlElement("suit")]
	public List<Suit> Suits { get; init; } = [];
	
	[XmlElement("tank")]
	public List<Tank> Tanks { get; init; } = [];
	
	[XmlElement("tankdata")]
	public List<TankData> TankData { get; init; } = [];
	
	[XmlElement("variouspieces")]
	public List<VariousPieces> VariousPieces { get; init; } = [];
	
	[XmlElement("videocamera")]
	public List<VideoCamera> VideoCameras { get; init; } = [];
	
	[XmlElement("watch")]
	public List<Watch> Watches { get; init; } = [];
}
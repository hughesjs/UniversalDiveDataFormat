using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public abstract class EquipmentDetails : ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }

	[XmlElement("name")]
	public required string Name { get; init; }

	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];

	[XmlElement("manufacturer")]
	public required Manufacturer Manufacturer { get; init; }

	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];

	[XmlElement("model")]
	public required string Model { get; init; }

	[XmlElement("nextservicedate")]
	public NextServiceDate? NextServiceDate { get; init; }

	[XmlElement("notes")]
	public Notes? Notes { get; init; }

	[XmlElement("purchase")]
	public Purchase? Purchase { get; init; }

	[XmlElement("serialnumber")]
	public string? SerialNumber { get; init; }

	[XmlElement("serviceinterval")]
	public int? ServiceIntervalInDays { get; init; }
	
}

[XmlRoot("buoyancycontroldevice")]
public class BuoyancyControlDevice : EquipmentDetails;

[XmlRoot("boots")]
public class Boots : EquipmentDetails;

[XmlRoot("compass")]
public class Compass : EquipmentDetails;

[XmlRoot("compressor")]
public class Compressor : EquipmentDetails;

[XmlRoot("divecomputer")]
public class DiveComputer : EquipmentDetails;

[XmlRoot("fins")]
public class Fins : EquipmentDetails;

[XmlRoot("gloves")]
public class Gloves : EquipmentDetails;

[XmlRoot("knife")]
public class Knife : EquipmentDetails;

[XmlRoot("lead")]
public class Lead : EquipmentDetails;

[XmlRoot("light")]
public class Light : EquipmentDetails;

[XmlRoot("mask")]
public class Mask : EquipmentDetails;

[XmlRoot("rebreather")]
public class Rebreather : EquipmentDetails;

[XmlRoot("regulator")]
public class Regulator : EquipmentDetails;

[XmlRoot("scooter")]
public class Scooter : EquipmentDetails;

[XmlRoot("suit")]
public class Suit : EquipmentDetails
{ 
	[XmlElement("suittype")]
	public SuitType? SuitType { get; init; }
}

[XmlRoot("tank")]
public class Tank : EquipmentDetails
{
	[XmlElement("tankmaterial")]
	public TankMaterial? TankMaterial { get; init; }
	
	[XmlElement("tankvolume")]
	public float? TankVolumeInMetersCubed { get; init; }
}

[XmlRoot("variouspieces")]
public class VariousPieces : EquipmentDetails;

[XmlRoot("watch")]
public class Watch : EquipmentDetails;

[XmlRoot("body")]
public class Body: EquipmentDetails;

[XmlRoot("flash")]
public class Flash : EquipmentDetails;

[XmlRoot("housing")]
public class Housing : EquipmentDetails;

[XmlRoot("lens")]
public class Lens : EquipmentDetails;  

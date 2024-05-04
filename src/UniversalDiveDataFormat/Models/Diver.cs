using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("diver")]
public class Diver
{
	[XmlElement("owner")]
	public required Owner Owner { get; init; }
	
	[XmlElement("buddy")]
	public List<Buddy> Buddies { get; init; } = [];
}

public class Owner : ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }

	[XmlElement("address")]
	public Address? Address { get; init; }

	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("diveinsurances")]
	public DiveInsurances? DiveInsurances { get; init; }
	
	[XmlElement("divepermissions")]
	public DivePermissions? DivePermissions { get; init; }
	
	[XmlElement("education")]
	public Education? Education { get; init; }
	
	[XmlElement("equipment")]
	public Equipment? Equipment { get; init; }
	
	[XmlElement("medical")]
	public Medical? Medical { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("personal")]
	public required Personal Personal { get; init; }
}
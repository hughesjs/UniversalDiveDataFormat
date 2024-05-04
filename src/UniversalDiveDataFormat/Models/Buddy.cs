using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("buddy")]
public class Buddy: ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }
	
	[XmlElement("address")]
	public Address? Address { get; init; }

	// The docs are unclear here. The child element lists certifications but the sample data has education
	[XmlElement("education")]
	public required List<Education> Education { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("diveinsurances")]
	public DiveInsurances? DiveInsurances { get; init; }
	
	[XmlElement("divepermissions")]
	public DivePermissions? DivePermissions { get; init; }
	
	[XmlElement("equipment")]
	public Equipment? Equipment { get; init; }
	
	[XmlElement("medical")]
	public Medical? Medical { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("personal")]
	public required Personal Personal { get; init; }
	
	[XmlElement("student")]
	public bool Student { get; init; }
}


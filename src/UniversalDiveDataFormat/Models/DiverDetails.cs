using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public abstract class DiverDetails : ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("address")]
	public Address? Address { get; init; }

	// The docs are unclear here. The child element lists certifications here for buddy but the sample data has 
	// I'm going to assume this is meant to be the same as for Owner
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
	public Student? Student { get; init; }
	
	[XmlIgnore]
	public bool IsStudent => Student is not null;
}

[XmlRoot("buddy")]
public class Buddy : DiverDetails;

[XmlRoot("owner")]
public class Owner : DiverDetails;

[XmlRoot("student")]
public class Student;
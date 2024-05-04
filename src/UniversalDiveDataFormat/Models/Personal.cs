using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("personal")]
public class Personal
{
	[XmlElement("birthdate")]
	public BirthDate? BirthDate { get; init; }
	
	[XmlElement("birthname")]
	public string? BirthName { get; init; }
	
	[XmlElement("bloodgroup")]
	public BloodGroup? BloodGroup { get; init; }
	
	[XmlElement("firstname")]
	public required string FirstName { get; init; }
	
	[XmlElement("middlename")]
	public string? MiddleName { get; init; }
	
	[XmlElement("lastname")]
	public required string LastName { get; init; }
	
	[XmlElement("height")]
	public float? HeightInMeters { get; init; }
	
	[XmlElement("weight")]
	public float? WeightInKg { get; init; }
	
	[XmlElement("honorific")]
	public string? Honorifics { get; init; }
	
	[XmlElement("membership")]
	public List<Membership> Memberships { get; init; } = [];
	
	[XmlElement("numberofdives")]
	public NumberOfDives? NumberOfDives { get; init; }
	
	[XmlElement("passport")]
	public string? PassportNumber { get; init; }
	
	[XmlElement("sex")]
	public Sex? Sex { get; init; }
	
	[XmlElement("smoker")]
	public SmokerStatus? SmokerStatus { get; init; }
}
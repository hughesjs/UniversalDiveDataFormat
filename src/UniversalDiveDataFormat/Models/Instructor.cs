using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("instructor")]
public class Instructor: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("personal")]
	public required Personal Personal { get; init; }
	
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }  
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}
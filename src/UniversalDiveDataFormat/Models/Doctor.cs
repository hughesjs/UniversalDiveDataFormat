using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("doctor")]
public class Doctor: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("personal")]
	public required Personal Personal { get; init; }
}
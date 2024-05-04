using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("doctor")]
public class Doctor: ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }
	
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("personal")]
	public required Personal Personal { get; init; }
}
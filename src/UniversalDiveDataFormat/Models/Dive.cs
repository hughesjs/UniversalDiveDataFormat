using System.Xml;
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("dive")]
public class Dive : ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("informationafterdive")]
	public required InformationAfterDive InformationAfterDive { get; init; }
	
	[XmlElement("informationbeforedive")]
	public required InformationBeforeDive InformationBeforeDive { get; init; }
	
	[XmlElement("applicationdata")]
	public XmlElement? ApplicationData { get; init; } // This stuff is application-specific
	
	[XmlElement("samples")]
	public Samples? Samples { get; init; }

	[XmlElement("tankdata")]
	public TankData? TankData { get; init; }

}
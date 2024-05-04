using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("guide")]
public class Guide: ILinkable
{
	[XmlAttribute("id")]
	public string Id { get; init; }
	
	[XmlElement("link")]
	public Link? Link { get; init; }
}
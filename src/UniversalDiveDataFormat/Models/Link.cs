using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("link")]
public class Link
{
	[XmlAttribute("ref")]
	public required string Ref { get; init; }
	
	// public ILinkable? LinkedObject { get; init; }
}
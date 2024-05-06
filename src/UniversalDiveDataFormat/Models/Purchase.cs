using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("purchase")]
public class Purchase: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("price")]
	public Price? Price { get; init; } 
	
	[XmlElement("shop")]
	public Shop? Shop { get; init; }
}
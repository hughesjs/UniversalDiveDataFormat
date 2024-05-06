using System.Xml;
using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("bottomtimetable")]
public class BottomTimeTable: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("applicationdata")]
	public XmlElement? ApplicationData { get; init; } // This stuff is application-specific 
	
	[XmlElement("bottomtimetablescope")]
	public required BottomTimeTableScope BottomTimeTableScope { get; init; }
	
	[XmlElement("output")]
	public Output? Output { get; init; }
	
	[XmlElement("title")]
	public string? Title { get; init; }
	
}
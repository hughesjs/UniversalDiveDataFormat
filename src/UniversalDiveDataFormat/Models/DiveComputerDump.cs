using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divecomputerdump")]
public class DiveComputerDump
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("dcdump")]
	public required string DcDump { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("observations")]
public class Observations
{
	[XmlElement("flora")]
	public List<Flora> Flora { get; init; } = [];
	
	[XmlElement("fauna")]
	public List<Fauna> Fauna { get; init; } = [];
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}
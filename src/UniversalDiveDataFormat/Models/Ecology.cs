using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("ecology")]
public class Ecology
{
	[XmlElement("flora")]
	public Flora? Flora { get; init; } 

	[XmlElement("fauna")]
	public Fauna? Fauna { get; init; }

}
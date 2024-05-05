using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("fauna")]
public class Fauna
{
	[XmlElement("vertebrata")]
	public Vertebrata? Vertebrata { get; init; } 
	
	[XmlElement("invertebrata")]
	public Invertebrata? Invertebrata { get; init; }
}
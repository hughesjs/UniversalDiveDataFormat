using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("fauna")]
public class Fauna: UddfModel
{
	[XmlElement("vertebrata")]
	public Vertebrata? Vertebrata { get; init; } 
	
	[XmlElement("invertebrata")]
	public Invertebrata? Invertebrata { get; init; }
}
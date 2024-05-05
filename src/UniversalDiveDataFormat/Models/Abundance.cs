using System.Globalization;
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("abundance")]
public class Abundance
{
	[XmlAttribute("quality")]
	public Quality Quality { get; init; }
	
	[XmlAttribute("occurrence")]
	public Occurrence Occurrence { get; init; }
	
	[XmlText]
	public int Value { get; init; }
}
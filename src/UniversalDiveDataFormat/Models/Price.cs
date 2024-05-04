using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("Price")]
public class Price
{
	[XmlElement("currency")]
	public string? Currency { get; init; }
	
	[XmlText]
	public decimal? Value { get; init; }
}
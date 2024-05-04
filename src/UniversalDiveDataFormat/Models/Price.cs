using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("price")]
public class Price
{
	[XmlAttribute("currency")]
	public string? Currency { get; init; }
	
	[XmlText]
	public decimal Value { get; init; }
}

[XmlRoot("priceperdive")]
public class PricePerDive : Price;

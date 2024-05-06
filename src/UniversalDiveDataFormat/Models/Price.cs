using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("price")]
public class Price: UddfModel
{
	[XmlAttribute("currency")]
	public string? Currency { get; init; }
	
	[XmlText]
	public decimal Value { get; init; }
}

[XmlRoot("pricedivepackage")]
public class PriceDivePackage: Price
{

	[XmlAttribute("noofdives")]
	public required int NumberOfDives { get; init; }
}


[XmlRoot("priceperdive")]
public class PricePerDive: Price;

[XmlRoot("priceperlitre")]
public class PricePerLiter: Price;

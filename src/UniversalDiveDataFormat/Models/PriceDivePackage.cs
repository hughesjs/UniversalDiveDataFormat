using System.Globalization;
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("pricedivepackage")]
public class PriceDivePackage: Price
{

	[XmlAttribute("noofdives")]
	public required int NumberOfDives { get; init; }
	
}

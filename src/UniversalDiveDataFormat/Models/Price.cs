using System.Globalization;
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("price")]
public class Price
{
	[XmlAttribute("currency")]
	public string? Currency { get; init; }

	// Needed because you can't have a decimal in an XML element apparently
	// Unfortunately, that means I have to expose this
	[XmlText]
	public string? RawValue { private get; set; }

	[XmlIgnore]
	public decimal? Value
	{
		get => decimal.TryParse(RawValue, out decimal value) ? value : null;
		
		set => RawValue = value?.ToString(CultureInfo.InvariantCulture);
	}
}

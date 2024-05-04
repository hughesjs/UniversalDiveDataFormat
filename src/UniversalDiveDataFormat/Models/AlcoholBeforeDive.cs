using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("alcoholbeforedive")]
public class AlcoholBeforeDive
{
	[XmlElement("drink")]
	public List<Drink> Drinks { get; init; } = [];
}
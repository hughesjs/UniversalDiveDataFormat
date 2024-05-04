using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("maker")]
public class Maker
{
	[XmlElement("manufacturer")]
	public List<Manufacturer> Manufacturers { get; init; } = [];
}	


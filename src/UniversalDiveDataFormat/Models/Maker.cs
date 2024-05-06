using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("maker")]
public class Maker: UddfModel
{
	[XmlElement("manufacturer")]
	public List<Manufacturer> Manufacturers { get; init; } = [];
}	


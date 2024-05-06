using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("sunk")]
public class Sunk: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? Date { get; init; }
}
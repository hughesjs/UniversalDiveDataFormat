using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("sunk")]
public class Sunk
{
	[XmlElement("datetime")]
	public DateTime? Date { get; init; }
}
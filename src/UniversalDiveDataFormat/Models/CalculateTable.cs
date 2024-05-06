using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("calculatetable")]
public class CalculateTable: UddfModel
{
	[XmlElement("table")]
	public List<Table> Tables { get; init; } = [];
}
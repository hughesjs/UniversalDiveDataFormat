using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("calculatetable")]
public class CalculateTable
{
	[XmlElement("table")]
	public List<Table> Tables { get; init; } = [];
}
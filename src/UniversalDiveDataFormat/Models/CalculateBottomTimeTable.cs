using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("calculatebottomtimetable")]
public class CalculateBottomTimeTable
{
	[XmlElement("bottomtimetable")]
	public List<BottomTimeTable> BottomTimeTables { get; init; } = [];
}
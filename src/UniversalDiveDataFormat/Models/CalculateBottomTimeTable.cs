using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("calculatebottomtimetable")]
public class CalculateBottomTimeTable: UddfModel
{
	[XmlElement("bottomtimetable")]
	public List<BottomTimeTable> BottomTimeTables { get; init; } = [];
}
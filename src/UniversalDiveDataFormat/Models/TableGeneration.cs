using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("tablegeneration")]
public class TableGeneration
{
	[XmlElement("calculatebottomtimetable")]
	public CalculateBottomTimeTable? CalculateBottomTimeTable { get; init; }
	
	[XmlElement("calculateprofile")]
	public CalculateProfile? CalculateProfile { get; init; }
	
	[XmlElement("calculatetable")]
	public CalculateTable? CalculateTable { get; init; }
}
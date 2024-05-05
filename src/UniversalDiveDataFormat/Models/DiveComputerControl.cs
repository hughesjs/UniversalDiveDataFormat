using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divecomputercontrol")]
public class DiveComputerControl
{
	[XmlElement("divecomputerdump")]
	public List<DiveComputerDump> DiveComputerDumps { get; init; } = [];
	
	[XmlElement("getdcdata")]
	public GetDiveComputerData? GetDiveComputerData { get; init; }
	
	[XmlElement("setdcdata")]
	public SetDiveComputerData? SetDiveComputerData { get; init; }
}
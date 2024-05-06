using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divepermissions")]
public class DivePermissions: UddfModel
{
	[XmlElement("permit")]
	public List<Permit> Permits { get; init; } = [];
}
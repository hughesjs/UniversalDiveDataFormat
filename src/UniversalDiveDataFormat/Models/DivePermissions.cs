using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divepermissions")]
public class DivePermissions
{
	[XmlElement("permit")]
	public List<Permit> Permits { get; init; } = [];
}
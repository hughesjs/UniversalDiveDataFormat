using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("table")]
public class Table:  Profile
{
	[XmlElement("tablescope")]
	public required TableScope TableScope { get; init; }
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("anysymptoms")]
public class AnySymptoms: UddfModel
{
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}
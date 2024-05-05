using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("anysymptoms")]
public class AnySymptoms
{
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}
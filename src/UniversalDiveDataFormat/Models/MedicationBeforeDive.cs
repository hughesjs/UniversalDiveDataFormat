using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("medicationbeforedive")]
public class MedicationBeforeDive
{
	[XmlElement("medicine")]
	public List<Medicine> Medicines { get; init; } = [];
}
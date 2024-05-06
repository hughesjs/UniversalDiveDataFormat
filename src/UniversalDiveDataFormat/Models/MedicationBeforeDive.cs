using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("medicationbeforedive")]
public class MedicationBeforeDive: UddfModel
{
	[XmlElement("medicine")]
	public List<Medicine> Medicines { get; init; } = [];
}
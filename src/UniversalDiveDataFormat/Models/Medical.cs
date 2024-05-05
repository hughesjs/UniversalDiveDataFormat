using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("medical")]
public class Medical
{
	[XmlElement("examination")]
	public List<MedicalExamination> Examinations { get; init; } = [];
}
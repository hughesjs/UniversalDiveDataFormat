using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("examination")]
public class MedicalExamination
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("doctor")]
	public Doctor? Doctor { get; init; }
	
	[XmlElement("examinationresult")]
	public ExaminationResult? ExaminationResult { get; init; }
	
	[XmlElement("totallungcapacity")]
	public float? TotalLungCapacityInMetersCubed { get; init; }
	
	[XmlElement("vitalcapacity")]
	public float? VitalCapacityInMetersCubed { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}
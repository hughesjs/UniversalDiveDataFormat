using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("examinationresult")]
public enum ExaminationResult
{
	[XmlEnum("passed")]
	Passed,
	
	[XmlEnum("failed")]
	Failed
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("thermalcomfort")]
public enum ThermalComfortType
{

	[XmlEnum("not-indicated")]
	NotIndicated,
	[XmlEnum("comfortable")]
	Comfortable,
	[XmlEnum("cold")]
	Cold,
	[XmlEnum("very-cold")]
	VeryCold,
	[XmlEnum("hot")]
	Hot
}
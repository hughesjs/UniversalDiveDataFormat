using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("program")]
public enum ProgramType
{
	[XmlEnum("other")]
	Other,
	[XmlEnum("recreation")]
	Recreation,
	[XmlEnum("training")]
	Training,
	[XmlEnum("scientific")]
	Scientific,
	[XmlEnum("medical")]
	Medical,
	[XmlEnum("commercial")]
	Commercial,
	[XmlEnum("military")]
	Military,
	[XmlEnum("competitive")]
	Competitive
}
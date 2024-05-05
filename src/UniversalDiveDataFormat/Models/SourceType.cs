using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public enum SourceType
{
	[XmlEnum("converter")]
	Converter,

	[XmlEnum("divecomputer")]
	DiveComputer,

	[XmlEnum("logbook")]
	Logbook
}
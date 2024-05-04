using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("periodicallytaken")]
public enum PeriodicallyTaken
{
	[XmlEnum("no")]
	No,
	
	[XmlEnum("yes")]
	Yes
}
using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public abstract class Drug: UddfModel
{
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];

	[XmlElement("name")]
	public required string Name { get; init; }

	[XmlElement("notes")]
	public Notes? Notes { get; init; }

	[XmlElement("periodicallytaken")]
	public PeriodicallyTaken? PeriodicallyTaken { get; init; }
	
	[XmlElement("timespanbeforedive")]
	public float? TimeSpanBeforeDiveInSeconds { get; init; }
}

[XmlRoot("drink")]
public class Drink: Drug;


[XmlRoot("medicine")]
public class Medicine: Drug;
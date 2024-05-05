using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("dominance")]
public enum Dominance
{
	[XmlEnum("undetermined")]
	Undetermined,
	
	[XmlEnum("less-than-1/20")]
	LessThanOneTwentieth,
	
	[XmlEnum("1/20-up-to-1/4")]
	OneTwentiethToOneQuarter,
	
	[XmlEnum("1/4-up-to-1/2")]
	OneQuarterToOneHalf,
	
	[XmlEnum("1/2-up-to-3/4")]
	OneHalfToThreeQuarters,
	
	[XmlEnum("greater-than-3/4")]
	GreaterThanThreeQuarters,
	
	[XmlEnum("single-individual")]
	SingleIndividual
}
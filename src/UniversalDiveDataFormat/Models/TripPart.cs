using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("trippart")]
public class TripPart: UddfModel
{
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("accommodation")]
	public Accommodation? Accommodation { get; init; }
	
	[XmlElement("dateoftrip")]
	public DateOfTrip? DateOfTrip { get; init; }
	
	[XmlElement("geography")]
	public Geography? Geography { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("operator")]
	public Operator? Operator { get; init; }
	
	[XmlElement("pricedivepackage")]
	public PriceDivePackage? PriceDivePackage { get; init; }
	
	[XmlElement("priceperdive")]
	public PricePerDive? PricePerDive { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
	
	[XmlElement("relateddives")]
	public RelatedDives? RelatedDives { get; init; }
	
	[XmlElement("vessel")]
	public Vessel? Vessel { get; init; }
	
}
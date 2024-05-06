using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("divebase")]
public class DiveBase: UddfModel, ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("guide")]
	public List<Guide> Guides { get; init; } = [];
	
	[XmlElement("pricedivepackage")]
	public PriceDivePackage? PriceDivePackage { get; init; }
	
	[XmlElement("priceperdive")]
	public PricePerDive? PricePerDive { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
}
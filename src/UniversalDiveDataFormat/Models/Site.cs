using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("site")]
public class Site: ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("ecology")]
	public Ecology? Ecology { get; init; }
	
	[XmlElement("environment")]
	public Environment? Environment { get; init; }

	[XmlElement("geography")]
	public Geography? Geography { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
	
	[XmlElement("sitedata")]
	public SiteData? SiteData { get; init; }
}
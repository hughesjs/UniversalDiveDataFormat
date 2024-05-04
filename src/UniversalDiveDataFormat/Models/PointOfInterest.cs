using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public abstract class PointOfInterest : ILinkable
{
	[XmlAttribute("id")]
	public required string Id { get; init; }
	
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
}

[XmlRoot("lake")]
public class Lake : PointOfInterest;

[XmlRoot("cave")]
public class Cave : PointOfInterest;

[XmlRoot("river")]
public class River : PointOfInterest;

[XmlRoot("shore")]
public class Shore : PointOfInterest;

[XmlRoot("wreck")]
public class Wreck : PointOfInterest
{
	[XmlElement("built")]
	public Built? Built { get; init; }
	
	[XmlElement("nationality")]
	public string? Nationality { get; init; }
	
	[XmlElement("shipdimension")]
	public ShipDimension? ShipDimension { get; init; }
	
	[XmlElement("shiptype")]
	public string? ShipType { get; init; }
	
	[XmlElement("sunk")]
	public Sunk? Sunk { get; init; }
	
}

[XmlRoot("indoor")]
public class Indoor: PointOfInterest
{
	
	[XmlElement("address")]
	public Address? Address { get; init; }
	
	[XmlElement("contact")]
	public Contact? Contact { get; init; }
	
}
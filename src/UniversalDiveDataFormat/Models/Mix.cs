using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("mix")]
public class Mix: ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("ar")]
	public required float Argon { get; init; }
	
	[XmlElement("h2")]
	public required float Hydrogen { get; init; }  
	
	[XmlElement("he")]
	public required float Helium { get; init; }

	[XmlElement("n2")]
	public required float Nitrogen { get; init; }

	[XmlElement("o2")]
	public required float Oxygen { get; init; }
	
	[XmlElement("equivalentairdepth")]
	public required float EquivalentAirDepthInMeters { get; init; }
	
	[XmlElement("priceperlitre")]
	public PricePerLiter? PricePerLiter { get; init; }
	
	[XmlElement("maximumoperationdepth")]
	public required float MaximumOperationDepthInMeters { get; init; }
	
	[XmlElement("maximumpo2")]
	public required float MaximumPartialPressureOfOxygenInBars { get; init; }
	


	
}
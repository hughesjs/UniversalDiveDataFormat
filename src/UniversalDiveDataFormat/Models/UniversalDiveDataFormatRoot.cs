using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("uddf")]
public class UniversalDiveDataFormatRoot: UddfModel
{
	[XmlAttribute("version")]
	public required string Version { get; init; }

	[XmlElement("generator")]
	public required Generator Generator { get; init; }

	[XmlElement("mediadata")]
	public MediaData? MediaData { get; init; }

	[XmlElement("maker")]
	public Maker? Maker { get; init; }

	[XmlElement("business")]
	public Business? Business { get; init; }

	[XmlElement("diver")]
	public Diver? Diver { get; init; }
	
	[XmlElement("divesite")]
	public DiveSite? DiveSite { get; init; }

	[XmlElement("gasdefinitions")]
	public GasDefinitions? GasDefinitions { get; init; }

	[XmlElement("decomodel")]
	public DecoModel? DecoModel { get; init; }

	[XmlElement("profiledata")]
	public ProfileData? ProfileData { get; init; }
	
	[XmlElement("tablegeneration")]
	public required TableGeneration TableGeneration { get; init; }
	
	[XmlElement("divetrip")]
	public DiveTrips? DiveTrip { get; init; }
	
	[XmlElement("divecomputercontrol")]
	public DiveComputerControl? DiveComputerControl { get; init; }
}
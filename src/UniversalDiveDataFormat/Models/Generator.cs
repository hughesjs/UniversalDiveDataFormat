using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("generator")]
public class Generator
{
	[XmlElement("name")]
	public required string Name { get; init; }

	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];

	[XmlElement("manufacturer")]
	public Manufacturer? Manufacturer { get; init; }

	[XmlElement("version")]
	public string? Version { get; init; }

	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }

	[XmlElement("link")]
	public string? LinkId { get; init; }

	[XmlElement("type")]
	public SourceType? SourceType { get; init; }
}

public class DiveComputerControl { }

public class DiveTrip { }

public class TableGeneration { }

public class ProfileData { }

public class DecoModel { }

public class GasDefinitions { }

public class DiveSite { }

public class Diver { }

public class Business { }

public class Maker { }

public class MediaData { }
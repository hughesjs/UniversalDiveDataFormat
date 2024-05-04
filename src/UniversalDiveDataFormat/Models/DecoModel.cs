using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("decomodel")]
public class DecoModel
{
	[XmlElement("buehlmann")]
	public List<Buehlmann> BuehlmannModels { get; init; } = [];
	
	[XmlElement("rgbm")]
	public List<Rgbm> RgbmModels { get; init; } = [];

	[XmlElement("vpm")]
	public List<Vpm> VpmModels { get; init; } = [];
}
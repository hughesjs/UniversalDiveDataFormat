using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("notes")]
public class Notes
{
	[XmlElement("para")]
	public List<string> Paragraphs { get; init; } = [];

	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
}
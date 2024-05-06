using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public interface ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
}
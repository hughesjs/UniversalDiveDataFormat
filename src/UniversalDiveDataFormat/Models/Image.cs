using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("image")]
public class Image : ILinkable
{
	[XmlAttribute("id")]
	public string? Id { get; init; }
	
	// These should ideally be int? but the serializer doesn't like that
	[XmlAttribute("height")]
	public int Height { get; init; }
	
	[XmlAttribute("width")]
	public int Width { get; init; }
	
	[XmlAttribute("format")]
	public string? Format { get; init; }
	
	[XmlElement("objectname")]
	public required string ObjectName { get; init; }
	
	[XmlElement("title")]
	public string? Title { get; init; }
	
	[XmlElement("imagedata")]
	public ImageData? ImageData { get; init; }
}
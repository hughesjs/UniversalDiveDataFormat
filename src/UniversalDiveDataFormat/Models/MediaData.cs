using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("mediadata")]
public class MediaData
{
	[XmlElement("audio")]
	public List<Audio> AudioFiles { get; init; } = [];
	[XmlElement("video")]
	public List<Video> VideoFiles { get; init; } = [];
	[XmlElement("image")]
	public List<Image> ImageFiles { get; init; } = [];
}
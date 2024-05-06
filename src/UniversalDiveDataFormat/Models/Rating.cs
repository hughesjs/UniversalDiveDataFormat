using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("rating")]
public class Rating: UddfModel
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("ratingvalue")]
	public int Value { get; init; }
}
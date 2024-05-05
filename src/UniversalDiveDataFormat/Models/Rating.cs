using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("rating")]
public class Rating
{
	[XmlElement("datetime")]
	public DateTime? DateTime { get; init; }
	
	[XmlElement("ratingvalue")]
	public int Value { get; init; }
}
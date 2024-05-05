using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public class Membership
{
	[XmlAttribute("ogranisation")]
	public required string Organisation { get; init; }
	
	[XmlAttribute("memberid")]
	public required string MemberId { get; init; }
}
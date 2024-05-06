using System.Xml.Serialization;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("certification")]
public class Certification
{
	[XmlElement("level")]
	public string? Level { get; init; }
	
	[XmlElement("instructor")]
	public Instructor? Instructor { get; init; }
	
	[XmlElement("issuedate")]
	public IssueDate? IssueDate { get; init; }
	
	[XmlElement("link")]
	public List<Link> Links { get; init; } = [];
	
	[XmlElement("organization")]
	public string? Organization { get; init; }
	
	[XmlElement("specialty")]
	public string? Specialty { get; init; }
	
	[XmlElement("validdate")]
	public ValidDate? ValidDate { get; init; }
}

using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("permit")]
public class Permit
{
	[XmlElement("name")]
	public required string Name { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("issuedate")]
	public IssueDate? IssueDate { get; init; }
	
	[XmlElement("validdate")]
	public ValidDate? ValidDate { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }

	[XmlElement("region")]
	public string? Region { get; init; }
}
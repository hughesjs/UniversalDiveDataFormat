using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("insurance")]
public class Insurance
{
	[XmlElement("name")]
	public string? Name { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("aliasname")]
	public List<string> AliasNames { get; init; } = [];
	
	[XmlElement("issuedate")]
	public IssueDate? IssueDate { get; init; }
	
	[XmlElement("validdate")]
	public ValidDate? ValidDate { get; init; }
}
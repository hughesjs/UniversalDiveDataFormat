using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("issuedate")]
public class IssueDate: UddfModel
{
	[XmlElement("datetime")]
	public required DateTime DateTime { get; init; }
}
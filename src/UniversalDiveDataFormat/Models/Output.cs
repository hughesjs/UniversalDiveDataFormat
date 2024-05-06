using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("output")]
public class Output: UddfModel
{
	[XmlElement("lingo")]
	public string? Lingo { get; init; }
	
	[XmlElement("fileformat")]
	public string? FileFormat { get; init; }
	
	[XmlElement("filename")]
	public string? FileName { get; init; }
	
	[XmlElement("headline")]
	public string? Headline { get; init; }
	
	[XmlElement("remark")]
	public string? Remark { get; init; }
}
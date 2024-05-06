using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcpassword")]
public class SetDiveComputerPassword: UddfModel
{
	[XmlText]
	public required string Password { get; init; }
}
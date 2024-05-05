using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcpassword")]
public class SetDiveComputerPassword
{
	[XmlText]
	public required string Password { get; init; }
}
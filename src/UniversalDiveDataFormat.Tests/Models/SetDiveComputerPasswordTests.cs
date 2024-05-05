using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerPasswordTests
{
	private const string Xml = "<setdcpassword>123456789</setdcpassword>";
	
	[Fact]
	public void CanReadSetDcPassword()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerPassword));
		SetDiveComputerPassword setDcPassword = serializer.Deserialize<SetDiveComputerPassword>(Xml);
		setDcPassword.Password.ShouldBe("123456789");
	}
}
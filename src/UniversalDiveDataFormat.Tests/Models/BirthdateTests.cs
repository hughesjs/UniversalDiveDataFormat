using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BirthdateTests
{
	private const string Xml = """
	                           <birthdate>
	                               <datetime>1919-02-28</datetime>
	                           </birthdate>
	                           """;
	
	[Fact]
	public void CanReadBirthdate()
	{
		XmlSerializer serializer = new(typeof(BirthDate));
		BirthDate birthDate = serializer.Deserialize<BirthDate>(Xml);
		birthDate.DateTime.ShouldBe(new DateTime(1919, 2, 28));
	}
}
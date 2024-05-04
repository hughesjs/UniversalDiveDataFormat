using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class PersonalTests
{
	private const string Xml = """
	                           <personal>
	                               <firstname>Arno</firstname>
	                               <middlename>Albert</middlename>
	                               <lastname>Alzheimer</lastname>
	                               <honorific>Dr.</honorific>
	                               <sex>male</sex>
	                               <birthdate>
	                                   <datetime>1919-02-28</datetime>
	                               </birthdate>
	                               <passport>123456789</passport>
	                               <bloodgroup>A</bloodgroup>
	                           </personal>
	                           """;
	
	[Fact]
	public void CanReadPersonal()
	{
		XmlSerializer serializer = new(typeof(Personal));
		Personal personal = serializer.Deserialize<Personal>(Xml);
		personal.FirstName.ShouldBe("Arno");
		personal.MiddleName.ShouldBe("Albert");
		personal.LastName.ShouldBe("Alzheimer");
		personal.Honorifics.ShouldBe("Dr.");
		personal.Sex.ShouldBe(Sex.Male);
		personal.BirthDate.ShouldNotBeNull();
		personal.PassportNumber.ShouldBe("123456789");
		personal.BloodGroup.ShouldBe(BloodGroup.A);
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DoctorTests
{
	private const string Xml = """
	                           <doctor>
	                               <personal>
	                                   <firstname>Dirk</firstname>
	                                   <lastname>Dusel</lastname>
	                                   <honorific>Dr.</honorific>
	                                   <sex>male</sex>
	                                   <birthdate>
	                                       <!-- if date of birthdate known, it can be given here -->
	                                   </birthdate>
	                               </personal>
	                               <address>
	                                   <street>Duddelstr. 34</street>
	                                   <city>Dortmund</city>
	                                   <postcode>54321</postcode>
	                                   <country>Germany</country>
	                               </address>
	                               <contact>
	                                   <language>German</language>
	                                   <phone>01234/987654</phone>
	                                   <!-- neither email address nor homepage known -->
	                               </contact>
	                           </doctor>
	                           """;
	
	[Fact]
	public void CanReadDoctor()
	{
		XmlSerializer serializer = new(typeof(Doctor));
		Doctor doctor = serializer.Deserialize<Doctor>(Xml);
		doctor.Personal.ShouldNotBeNull();
		doctor.Address.ShouldNotBeNull();
		doctor.Contact.ShouldNotBeNull();
	}
}
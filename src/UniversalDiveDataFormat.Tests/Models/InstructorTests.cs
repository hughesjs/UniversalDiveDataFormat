using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class InstructorTests
{
	private const string Xml = """
	                           <instructor id="di2_ijk>
	                               <!-- description of dive instructor -->
	                               <personal>
	                                   <firstname>Ingo</firstname>
	                                   <middlename>Jürgen</middlename>
	                                   <lastname>Knattermann</lastname>
	                                   <sex>male</sex>
	                                   <birthdate>
	                                       <!-- date of birthdate not known -> statements omitted -->
	                                   </birthdate>
	                                   <address>
	                                       <!-- address not known -> statements omitted -->
	                                   </address>
	                               </personal>
	                               <contact>
	                                   <language>deutsch</language>
	                                   <!-- phone number unknown -> <phone> element omitted -->
	                                   <email>ijk@knattermanns_tauchschule.de</email>
	                                   <homepage>http://www.knattermanns_tauchschule.de</homepage>
	                               </contact>
	                               <notes>
	                                   <!-- here more text-information, pictures etc. -->
	                               </notes>
	                           </instructor>
	                           """;
	
	[Fact]
	public void CanReadInstructor()
	{
		XmlSerializer serializer = new(typeof(Instructor));
		Instructor instructor = serializer.Deserialize<Instructor>(Xml);
		instructor.Id.ShouldBe("di2_ijk");
		instructor.Personal.ShouldNotBeNull();
		instructor.Contact.ShouldNotBeNull();
		instructor.Notes.ShouldNotBeNull();
	}
}
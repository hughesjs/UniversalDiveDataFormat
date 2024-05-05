using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class CertificationTests
{
	private const string Xml = """
	                           <certification>
	                               <specialty>Strömungstauchen</specialty>
	                               <level>Gold</level>
	                               <organization>VDST</organization>
	                               <instructor>
	                                   <personal>
	                                       <firstname>Ingo</firstname>
	                                       <middlename>Jürgen</middlename>
	                                       <lastname>Knattermann</lastname>
	                                       <sex>male</sex>
	                                       <birthdate>
	                                           <!-- date of birthdate not known -> statements omitted -->
	                                       </birthdate>
	                                   </personal>
	                                   <address>
	                                       <!-- address not known -> statements omitted -->
	                                   </address>
	                                   <contact>
	                                       <language>German</language>
	                                       <!-- phone number unknown -> <phone> element omitted -->
	                                       <email>ijk@knattermanns_tauchschule.de</email>
	                                       <homepage>http://www.knattermanns_tauchschule.de</homepage>
	                                   </contact>
	                               </instructor>
	                               <issuedate>
	                                   <datetime>2005-08-27</datetime>
	                               </issuedate>
	                               <validdate>
	                                   <datetime>2005-08-27</datetime>
	                               </validdate>
	                           </certification>
	                           """;
	
	[Fact]
	public void CanReadCertification()
	{
		XmlSerializer serializer = new(typeof(Certification));
		Certification certification = serializer.Deserialize<Certification>(Xml);
		certification.Level.ShouldBe("Gold");
		certification.Organization.ShouldBe("VDST");
		certification.Instructor.ShouldNotBeNull();
		certification.IssueDate.ShouldNotBeNull();
		certification.Links.Count.ShouldBe(0);
		certification.Specialty.ShouldBe("Strömungstauchen");
		certification.ValidDate.ShouldNotBeNull();
	}
	
}
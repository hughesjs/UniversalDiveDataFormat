using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class EducationTests
{
	private const string Xml = """
	                           <education>
	                               <!-- all levels of the owner's, or a buddy's, dive education -->
	                               <!-- -> several <certification> elements one after the other -->
	                               <certification>
	                                   <level>Bronze</level>
	                                   <organisation>VDST/CMAS</organisation>
	                                   <!-- because data of the then dive instructor were not -->
	                                   <!-- registered in an UDDF file, no reference via      -->
	                                   <!-- <link ref="..."/> can be made here    -->
	                                   <issuedate>
	                                       <datetime>1994-03-15</datetime>
	                                   </issuedate>
	                               </certification>
	                               <certification>
	                                   <level>Silver</level>
	                                   <organisation>VDST/CMAS</organisation>
	                                   <!-- because data of the then dive instructor were not -->
	                                   <!-- registered in an UDDF file, no reference via      -->
	                                   <!-- <link ref="..."/> can be made here    -->
	                                   <issuedate>
	                                       <datetime>1997-11-26</datetime>
	                                   </issuedate>
	                               </certification>
	                               <certification>
	                                   <level>Gold</level>
	                                   <organisation>VDST/CMAS</organisation>
	                                   <!-- because data of the then dive instructor were not -->
	                                   <!-- registered in an UDDF file, no reference via      -->
	                                   <!-- <link ref="..."/> can be made here    -->
	                                   <issuedate>
	                                       <datetime>2000-05-10</datetime>
	                                   </issuedate>
	                               </certification>
	                               <!-- here more <certification> elements if necessary -->
	                           </education>
	                           """;
	
	[Fact]
	public void CanReadEducation()
	{
		XmlSerializer serializer = new(typeof(Education));
		Education education = serializer.Deserialize<Education>(Xml);
		
		education.Certifications.Count.ShouldBe(3);
	}	
}
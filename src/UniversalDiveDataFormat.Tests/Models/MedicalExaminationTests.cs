using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MedicalExaminationTests
{
	private const string Xml = """
	                           <examination>
	                               <datetime>2003-04-12</datetime>
	                               <doctor>
	                                   <personal>
	                                       <firstname>Dirk</firstname>
	                                       <lastname>Dusel</lastname>
	                                       <honorific>Dr.</honorific>
	                                       <sex>male</sex>
	                                       <birthdate>
	                                           <!-- if date of birthdate is known, it can be given here -->
	                                       </birthdate>
	                                   </personal>
	                                   <address>
	                                       <street>Duddelstr. 34</street>
	                                       <city>Dortmund</city>
	                                       <postcode>54321</postcode>
	                                       <country>Deutschland</country>
	                                   </address>
	                                   <contact>
	                                       <language>deutsch</language>
	                                       <phone>01234/987654</phone>
	                                       <email>dusels_dirk@taucherarzt-dirk-dusel.de</email>
	                                       <homepage>http://www.taucherarzt-dirk-dusel.de</homepage>
	                                   </contact>
	                               </doctor>
	                               <examinationresult>passed</examinationresult>
	                               <totallungcapacity>0.0059</totallungcapacity>
	                               <vitalcapacity>0.0043</vitalcapacity>
	                               <notes>
	                                   <para>
	                                       Flatfeet seem to not affect diving ability. :-)
	                                   </para>
	                                   <link ref="img_flatfoot"/>
	                               </notes>
	                           </examination>         
	                           """;
	
	[Fact]
	public void CanReadMedicalExamination()
	{
		XmlSerializer serializer = new(typeof(MedicalExamination));
		MedicalExamination medicalExamination = serializer.Deserialize<MedicalExamination>(Xml);
		medicalExamination.DateTime.ShouldBe(new DateTime(2003, 4, 12));
		medicalExamination.Doctor.ShouldNotBeNull();
		medicalExamination.ExaminationResult.ShouldBe(ExaminationResult.Passed);
		medicalExamination.TotalLungCapacityInMetersCubed.ShouldBe(0.0059f);
		medicalExamination.VitalCapacityInMetersCubed.ShouldBe(0.0043f);
		medicalExamination.Notes.ShouldNotBeNull();
	}	
}
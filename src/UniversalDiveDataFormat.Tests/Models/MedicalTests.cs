using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MedicalTests
{
	private const string Xml = """
	                           <medical>
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
	                                       </birthdate
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
	                               <vitalcapacity>0.0043</totallungcapacity>
	                               <notes>
	                                   <para>
	                                       Flatfeet seem to not affect diving ability. :-)
	                                   </para>
	                                   <link ref="img_flatfoot"/>
	                               </notes>
	                           </examination>
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
	                                       </birthdate
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
	                               <vitalcapacity>0.0043</totallungcapacity>
	                               <notes>
	                                   <para>
	                                       Flatfeet seem to not affect diving ability. :-)
	                                   </para>
	                                   <link ref="img_flatfoot"/>
	                               </notes>
	                           </examination>
	                           </medical>
	                           """;
	
	[Fact]
	public void CanReadMedical()
	{
		XmlSerializer serializer = new(typeof(Medical));
		Medical medical = serializer.Deserialize<Medical>(Xml);
		medical.Examinations.Count.ShouldBe(2);
	}
}
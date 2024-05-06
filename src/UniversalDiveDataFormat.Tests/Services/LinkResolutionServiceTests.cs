using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;
using UniversalDiveDataFormat.Services;

namespace UniversalDiveDataFormat.Tests.Services;

public class LinkResolutionServiceTests
{
	private const string Xml = """
	                           <uddf version="3.2.0">
	                               <mediadata>
	                                   <image id="img_flatfeet">
	                                       <title>Arno's flatfeet...</title>
	                                       <objectname>flatfeet.jpg</objectname>
	                                   </image>
	                               </mediadata>
	                               <diver>
	                                   <owner id="owner_arno">
	                                       <personal>

	                                       </personal>
	                                       <address>

	                                       </address>
	                                       <contact>
	
	                                       </contact>
	                                       <medical>
	                                           <examination>
	                                               <datetime>2003-04-12</datetime>
	                                               <doctor id="doctorDusel">
	                                                   <personal>
	                                                       <firstname>Dirk</firstname>
	                                                       <lastname>Dusel</lastname>
	                                                       <honorific>Dr.</honorific>
	                                                       <sex>male</sex>
	                                                       <birthdate>
	                                                       </birthdate>
	                                                   </personal>
	                                                   <address>
	                                                       <street>Duddelstr. 34</street>
	                                                       <city>Dortmund</city>
	                                                       <postcode>54321</postcode>
	                                                       <country>Deutschland</country>
	                                                       <province>Nordrhein-Westfalen</province>
	                                                   </address>
	                                                   <contact>
	                                                       <language>deutsch</language>
	                                                       <phone>01234/987654</phone>
	                                                   </contact>
	                                               </doctor>
	                                               <examinationresult>passed</examinationresult>
	                                               <notes>
	                                                   <para>
	                                                       Flatfeet don't seem to affect dive fitness :-)
	                                                   </para>
	                                                   <link ref="img_flatfeet"/>
	                                               </notes>
	                                           </examination>
	                                           <examination>
	                                               <datetime>2004-04-20</datetime>
	                                               <link ref="doctorDusel"/>
	                                               <examinationresult>passed</examinationresult>
	                                           </examination>
	                                       </medical>
	                                       <education>
	                                           <certification>
	                                               <level>Bronze</level>
	                                               <organisation>VDST/CMAS</organisation>
	                                               <issuedate>
	                                                   <datetime>1994-03-15</datetime>
	                                               </issuedate>
	                                           </certification>
	                                           <certification>
	                                               <specialty>Orientation</specialty>
	                                               <organisation>VDST/CMAS</organisation>
	                                               <issuedate>
	                                                   <datetime>1994-03-15</datetime>
	                                               </issuedate>
	                                           </certification>
	                                           <certification>
	                                               <level>Silver</level>
	                                               <organisation>VDST/CMAS</organisation>
	                                               <issuedate>
	                                                   <datetime>1997-11-26</datetime>
	                                               </issuedate>
	                                           </certification>
	                                           <certification>
	                                               <level>Gold</level>
	                                               <organisation>VDST/CMAS</organisation>
	                                               <issuedate>
	                                                   <datetime>2000-05-10</datetime>
	                                               </issuedate>
	                                           </certification>
	                                       </education>
	                                       <divepermissions>
	                                           <permit>
	                                               <name>DiveCard</name>
	                                               <region>Austria</region>
	                                               <issuedate>
	                                                   <datetime>2004-08-24</datetime>
	                                               </issuedate>
	                                               <validdate>
	                                                   <datetime>2005-08-23</datetime>
	                                               </validdate>
	                                           </permit>
	                                           <permit>
	                                               <name>Zeeland</name>
	                                               <region>Zeeland (The Netherlands)</region>
	                                               <issuedate>
	                                                   <datetime>1996-09-03:00</datetime>
	                                               </issuedate>
	                                               <validdate>
	                                                   <datetime>2001-08-31</datetime>
	                                               </validdate>
	                                           </permit>
	                                       </divepermissions>
	                                   </owner>
	                                   <buddy id="buddy_bertie_the_airsucker">
	                                       <personal>
	                                           <firstname>Bertie</firstname>
	                                           <lastname>Bammel</lastname>
	                                       </personal>
	                                       <contact>
	                                           <email>airsucker@deepdiving.info</email>
	                                           <homepage>http://www.deepdiving.info/bertie</homepage>
	                                       </contact>
	                                   </buddy>
	                                   <buddy id="buddyCarl">
	                                       <personal>
	                                           <firstname>Carl</firstname>
	                                           <lastname>Cabuff</lastname>
	                                       </personal>
	                                       <contact>
	                                           <email>lurchi@abcde.com</email>
	                                           <homepage>http://www.deepdiving.info/carl</homepage>
	                                       </contact>
	                                   </buddy>
	                               </diver>
	                           </uddf>
	                           """;

	[Fact]
	public void CanResolveLinks()
	{
		XmlSerializer serializer = new(typeof(UniversalDiveDataFormatRoot));
		UniversalDiveDataFormatRoot uddf = serializer.Deserialize<UniversalDiveDataFormatRoot>(Xml);
		
		LinkResolutionService lrs = new();
		lrs.ResolveAllLinksInObjectGraph(uddf);

		var linkedImage = uddf.MediaData!.ImageFiles[0];
		uddf.Diver!.Owner!.Medical!.Examinations[0].Notes!.Links[0].LinkedObject.ShouldBe(linkedImage);
	}
}
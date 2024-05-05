using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class IndoorTests
{
	private const string Xml = """
	                           <indoor>
	                               <name>monte mare</name>
	                               <address>
	                                   <street>Münstereifeler Straße 69</street>
	                                   <city>Rheinbach</city>
	                                   <postcode>53359</postcode>
	                                   <country>Germany</country>
	                               </address>
	                               <contact>
	                                   <language>German</language>
	                                   <phone>02226/9030-0</phone>
	                                   <email>rheinbach@montemare.de</email>
	                                   <homepage>http://www.monte-mare.de/de/rheinbach.html</homepage>
	                               </contact>
	                               <notes>
	                                   <link ref="img_montemare_1"/>
	                                   <link ref="img_montemare_2"/>
	                                   <link ref="img_montemare_3"/>
	                                   <link ref="video_clubdiving1846"/>
	                               </notes>
	                           </indoor>
	                           """;
	
	[Fact]
	public void CanReadIndoor()
	{
		XmlSerializer serializer = new(typeof(Indoor));
		Indoor indoor = serializer.Deserialize<Indoor>(Xml);
		indoor.Name.ShouldBe("monte mare");
		indoor.Address.ShouldNotBeNull();
		indoor.Contact.ShouldNotBeNull();
		indoor.Notes.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MakerTests
{
	private const string Xml = """
	                           <maker>
	                               <manufacturer id="manufacturer_lame_ducks">
	                                   <name>Lame Ducks Inc.</name>
	                                   <address>
	                                       <street>Lake Road 12</street>
	                                       <city>Laketown</city>
	                                       <postcode>91827</postcode>
	                                       <country>New Zealand</country>
	                                       <province>Wellington District</province>
	                                   </address>
	                                   <contact>
	                                       <phone>01234/987654</phone>
	                                       <mobilephone>0123/232323232</mobilephone>
	                                       <email>info@lame-ducks.com</email>
	                                       <homepage>http://www.lame-ducks.com</homepage>
	                                   </contact>
	                               </manufacturer>
	                               <manufacturer id="manufacturer_yellow_shark">
	                                   <name>Yellow Shark Company</name>
	                                   <address>
	                                       <!-- here address data of this manufacturer -->
	                                   </address>
	                                   <contact>
	                                       <!-- here contact data of this manufacturer -->
	                                   </contact>
	                               </manufacturer>
	                               <manufacturer id="manufacturer_great_oceans">
	                                   <name>Great Oceans Ltd.</name>
	                                   <address>
	                                       <!-- here address data of this manufacturer -->
	                                   </address>
	                                   <contact>
	                                       <!-- here contact data of this manufacturer -->
	                                   </contact>
	                               </manufacturer>
	                               <!-- here more declarations of manufacturers -->
	                           </maker>
	                           """;
	
	[Fact]
	public void CanReadMaker()
	{
		XmlSerializer serializer = new(typeof(Maker));
		Maker maker = serializer.Deserialize<Maker>(Xml);
		
		maker.Manufacturers.Count.ShouldBe(3);
	}
}
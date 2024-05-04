using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class PurchaseTests
{
	private const string Xml = """
	                           <purchase>
	                               <datetime>2002-05-04</datetime>
	                               <price currency="EUR">16.95</price>
	                               <shop>
	                                   <name>Wassersport-Freizeit Mader</name>
	                                   <address>
	                                       <street>Kornstr. 24</street>
	                                       <city>Unna</city>
	                                       <postcode>59625</postcode>
	                                       <country>Germany</country>
	                                   </address>
	                                   <contact>
	                                       <language>German</language>
	                                       <phone>02303/16514</phone>
	                                       <email>tauchsport-zentrale.mader@t-online.de</email>
	                                       <homepage>http://www.wassersport-freizeit-mader.de</homepage>
	                                   </contact>
	                               </shop>
	                           </purchase>
	                           """;
	
	[Fact]
	public void CanReadPurchase()
	{
		XmlSerializer serializer = new(typeof(Purchase));
		Purchase purchase = serializer.Deserialize<Purchase>(Xml);
		
		purchase.DateTime.ShouldBe(new DateTime(2002, 5, 4));
		purchase.Price.ShouldNotBeNull();
		purchase.Shop.ShouldNotBeNull();
	}
}
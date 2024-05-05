using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BusinessTests
{
	private const string Xml = """
	                           <business>
	                               <shop id="shop_the-professionals">
	                                   <name>The Professionals</name>
	                                   <address>
	                                       <street>Industry Road 123</street>
	                                       <city>Lakeside</city>
	                                       <postcode>35791</postcode>
	                                       <country>Scotland</country>
	                                   </address>
	                                   <contact>
	                                       <phone>04567/234567</phone>
	                                       <mobilephone>0123/787878787</mobilephone>
	                                       <email>info@the-professionals.com</email>
	                                       <homepage>http://www.the-professionals.com</homepage>
	                                   </contact>
	                               </shop>
	                               <shop id="shop_planet-dive">
	                                   <name>Planet Dive</name>
	                                   <address>
	                                       <!-- here address data of this manufacturer -->
	                                   </address>
	                                   <contact>
	                                       <!-- here contact data of this manufacturer -->
	                                   </contact>
	                               </shop>
	                               <shop id="shop_underwaterworld">
	                                   <name>Underwaterworld</name>
	                                   <address>
	                                       <!-- here address data of this manufacturer -->
	                                   </address>
	                                   <contact>
	                                       <!-- here contact data of this manufacturer -->
	                                   </contact>
	                               </shop>
	                               <!-- here more declarations of dive shops -->
	                           </business>
	                           """;

	[Fact]
	public void CanReadBusiness()
	{
		XmlSerializer serializer = new(typeof(Business));
		Business business = serializer.Deserialize<Business>(Xml);
		business.Shops.Count.ShouldBe(3);
	}
}
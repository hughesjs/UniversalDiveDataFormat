using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ShopTests
{
	private const string Xml = """
	                           <shop id="shop_the-deepdivers">
	                               <name>The DeepDivers</name>
	                               <address>
	                                   <!-- address data of shop where the equipment part was bought -->
	                               </address>
	                               <contact>
	                                   <!-- additional contact data (phone number, email address etc.) -->
	                               </contact>
	                               <notes>
	                                   <!-- additional remarks, pictures etc. -->
	                               </notes>
	                           </shop>
	                           """;
	
	[Fact]
	public void CanReadShop()
	{
		XmlSerializer serializer = new(typeof(Shop));
		Shop shop = (Shop)serializer.Deserialize(new StringReader(Xml))!;

		shop.Id.ShouldBe("shop_the-deepdivers");
		shop.Name.ShouldBe("The DeepDivers");
		shop.Address.ShouldNotBeNull();
		shop.Contact.ShouldNotBeNull();
		shop.Notes.ShouldNotBeNull();
	}
}
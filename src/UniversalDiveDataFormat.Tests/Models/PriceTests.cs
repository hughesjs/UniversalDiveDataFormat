using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class PriceTests
{
	private const string Xml = """
	                           <price currency="EUR">123.45</price>
	                           """;
	
	[Fact]
	public void CanReadPrice()
	{
		XmlSerializer serializer = new(typeof(Price));
		Price price = serializer.Deserialize<Price>(Xml);
		
		price.Currency.ShouldBe("EUR");
		price.Value.ShouldBe(123.45m);
	}
}
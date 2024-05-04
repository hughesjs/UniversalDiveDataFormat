using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class PriceDivePackageTests
{
	private const string Xml = """<pricedivepackage currency="EUR" noofdives="10">500.0</pricedivepackage>""";
	
	[Fact]
	public void CanReadPriceDivePackage()
	{
		XmlSerializer serializer = new(typeof(PriceDivePackage));
		PriceDivePackage priceDivePackage = serializer.Deserialize<PriceDivePackage>(Xml);
		priceDivePackage.Currency.ShouldBe("EUR");
		priceDivePackage.NumberOfDives.ShouldBe(10);
		priceDivePackage.Value.ShouldBe(500.0m);
	}
}
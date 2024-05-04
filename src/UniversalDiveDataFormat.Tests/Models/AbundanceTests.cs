using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class AbundanceTests
{

	
	[Fact]
	public void CanReadAbundanceWithQualityAndOccurrence()
	{
		const string xml = """<abundance occurrence="swarm" quality="estimated">30</abundance>""";
		XmlSerializer serializer = new(typeof(Abundance));
		Abundance abundance = serializer.Deserialize<Abundance>(xml);
		abundance.Value.ShouldBe(30);
		abundance.Quality.ShouldBe(Quality.Estimated);
		abundance.Occurrence.ShouldBe(Occurrence.Swarm);
	}
	
	[Fact]
	public void CanReadAbundanceWithValueOnly()
	{
		const string xml = "<abundance>30</abundance>";
		XmlSerializer serializer = new(typeof(Abundance));
		Abundance abundance = serializer.Deserialize<Abundance>(xml);
		abundance.Value.ShouldBe(30);
		abundance.Quality.ShouldBe(Quality.Unknown);
		abundance.Occurrence.ShouldBe(Occurrence.Unknown);
	}
}
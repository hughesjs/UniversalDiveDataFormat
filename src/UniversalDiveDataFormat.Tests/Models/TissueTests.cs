using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TissueTests
{
	private const string Xml = """<tissue gas="n2" number="6" halflife="2298.0" a="0.5043" b="0.8434"/>""";

	[Fact]
	public void CanReadTissue()
	{
		XmlSerializer serializer = new(typeof(Tissue));
		Tissue tissue = serializer.Deserialize<Tissue>(Xml);
		tissue.Gas.ShouldBe(Gas.Nitrogen);
		tissue.Number.ShouldBe(6);
		tissue.HalfLifeInSeconds.ShouldBe(2298.0f);
		tissue.A.ShouldBe(0.5043f);
		tissue.B.ShouldBe(0.8434f);
	}
}
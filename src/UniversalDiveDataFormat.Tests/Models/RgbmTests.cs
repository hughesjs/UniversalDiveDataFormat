using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class RgbmTests
{
	private const string Xml = """
	                            <rgbm id="rgbm_1">
	                                <tissue gas="n2" number="7" halflife="3258.0" a="0.441" b="0.8693"/>
	                           </rgbm>
	                           """;
	
	[Fact]
	public void CanReadRgbm()
	{
		XmlSerializer serializer = new(typeof(Rgbm));
		Rgbm rgbm = serializer.Deserialize<Rgbm>(Xml);
		rgbm.Id.ShouldBe("rgbm_1");
		rgbm.Tissues.Count.ShouldBe(1);
	}	
}
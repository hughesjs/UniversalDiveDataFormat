using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class VpmTests
{
	private const string Xml = """
	                            <vpm id="vpm-b">
	                                <conservatism>0.42</conservatism>
	                                <gamma>0.0179</gamma>
	                                <gc>0.257</gc>
	                                <lambda>367431.06061</lambda>
	                                <r0>1.0e-6</r0>
	                                <tissue gas="n2" number="8" halflife="4620.0" a="0.4" b="0.891"/>
	                           </vpm>
	                           """;
	
	[Fact]
	public void CanReadVpm()
	{
		XmlSerializer serializer = new(typeof(Vpm));
		Vpm vpm = serializer.Deserialize<Vpm>(Xml);
		vpm.Id.ShouldBe("vpm-b");
		vpm.Conservatism.ShouldBe(0.42f);
		vpm.Gamma.ShouldBe(0.0179f);
		vpm.Gc.ShouldBe(0.257f);
		vpm.Lambda.ShouldBe(367431.06061f);
		vpm.R0.ShouldBe(1.0e-6f);
		vpm.Tissues.Count.ShouldBe(1);
	}
}
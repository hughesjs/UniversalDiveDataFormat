using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MixTests
{
	private const string Xml = """
	                           <mix id="air">
	                               <name>air</name>
	                               <o2>0.210</o2>
	                               <n2>0.790</n2>
	                               <he>0.001</he>
	                               <ar>0.002</ar>
	                               <h2>0.003</h2>
	                               <priceperlitre currency="EUR">0.50</priceperlitre>
	                               <!-- using the information of the MOD the maximum tolerable PO2 can be -->
	                               <!-- calculated, therefore the latter need not to be given here -->
	                               <maximumoperationdepth>50.0</maximumoperationdepth>
	                           </mix>
	                           """;
	
	[Fact]
	public void CanReadMix()
	{
		XmlSerializer serializer = new(typeof(Mix));
		Mix mix = serializer.Deserialize<Mix>(Xml);
		mix.Id.ShouldBe("air");
		mix.Name.ShouldBe("air");
		mix.Oxygen.ShouldBe(0.210f);
		mix.Nitrogen.ShouldBe(0.790f);
		mix.Helium.ShouldBe(0.001f);
		mix.Argon.ShouldBe(0.002f);
		mix.Hydrogen.ShouldBe(0.003f);
		mix.PricePerLiter.ShouldNotBeNull();
		mix.MaximumOperationDepthInMeters.ShouldBe(50.0f);
		mix.MaximumPartialPressureOfOxygenInBars.ShouldBe(0.0f);
	}
}
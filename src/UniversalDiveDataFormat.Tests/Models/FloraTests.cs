using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class FloraTests
{
	private const string Xml = """
	                           <flora>
	                               <rhodophyceae>      <!-- red algae -->
	                               </rhodophyceae>
	                               <phaeophyceae>      <!-- brown algae -->
	                               </phaeophyceae>
	                               <chlorophyceae>     <!-- green algae -->
	                               </chlorophyceae>
	                               <spermatophyta>     <!-- flowering plants -->
	                               </spermatophyta>
	                               <floravarious>      <!-- all other plants -->
	                               </floravarious>
	                           </flora>
	                           """;
	
	[Fact]
	public void CanReadFlora()
	{
		XmlSerializer serializer = new(typeof(Flora));
		Flora flora = serializer.Deserialize<Flora>(Xml);
		flora.Rhodophyceae.Count.ShouldBe(1);
		flora.Phaeophyceae.Count.ShouldBe(1);
		flora.Chlorophyceae.Count.ShouldBe(1);
		flora.Spermatophyta.Count.ShouldBe(1);
		flora.FloraVarious.Count.ShouldBe(1);
	}
}
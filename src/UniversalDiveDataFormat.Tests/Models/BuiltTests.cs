using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BuiltTests
{
	private const string Xml = """
	                           <built>
	                               <shipyard>Blohm &amp; Voss</shipyard>
	                               <launchingdate>
	                                   <datetime>1943-06-14</datetime>
	                               </launchingdate>
	                           </built>
	                           """;
	
	[Fact]
	public void CanReadBuilt()
	{
		XmlSerializer serializer = new(typeof(Built));
		Built built = serializer.Deserialize<Built>(Xml);
		built.Shipyard.ShouldBe("Blohm & Voss");
		built.LaunchingDate.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class EcologyTests
{
	private const string Xml = """
	                           <ecology>
	                               <fauna>
	                                   <!-- here typically found animal species at this dive spot -->
	                               </fauna>
	                               <flora>
	                                   <!-- here typically found plant species at this dive spot -->
	                               </flora>
	                           </ecology>
	                           """;
	
	[Fact]
	public void CanReadEcology()
	{
		XmlSerializer serializer = new(typeof(Ecology));
		Ecology ecology = serializer.Deserialize<Ecology>(Xml);
		ecology.Fauna.ShouldNotBeNull();
		ecology.Flora.ShouldNotBeNull();
	}
}
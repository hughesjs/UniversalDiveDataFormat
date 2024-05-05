using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DiverTests
{
	private const string Xml = """
	                           <diver>
	                               <owner id="kai">
	                                   <!-- description of the owner of the UDDF file -->
	                               </owner>
	                               <buddy id="gerd">
	                                   <!-- description of the first dive buddy -->
	                               </buddy>
	                               <buddy id="dieter">
	                                   <!-- description of the second dive buddy -->
	                               </buddy>
	                               <buddy id="elmar">
	                                   <!-- description of the third dive buddy -->
	                               </buddy>
	                               <!-- here more <buddy> elements if necessary -->
	                           </diver>
	                           """;
	
	[Fact]
	public void CanReadDiver()
	{
		XmlSerializer serializer = new(typeof(Diver));
		Diver diver = serializer.Deserialize<Diver>(Xml);
		diver.Owner.Id.ShouldBe("kai");
		diver.Buddies.Count.ShouldBe(3);
	}
}
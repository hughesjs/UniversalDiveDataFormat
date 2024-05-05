using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DiveSiteTests
{
	private const string Xml = """
	                           <divesite>
	                               <divebase id="db-1">
	                                   <!-- here description of the first dive base -->
	                               </divebase>
	                               <divebase id="db-2">
	                                   <!-- here description of the second dive base -->
	                               </divebase>
	                               <divebase id="db-3">
	                                   <!-- here description of the third dive base -->
	                               </divebase>
	                               <!-- here more <divebase> elements if necessary -->
	                               <site id="site-1">
	                                   <!-- here description of the first dive site -->
	                               </site>
	                               <site id="site-2">
	                                   <!-- here description of the second dive site -->
	                               </site>
	                               <site id="site-3">
	                                   <!-- here description of the third dive site -->
	                               </site>
	                               <!-- here more <site> elements if necessary -->
	                           </divesite>
	                           """;
	
	[Fact]
	public void CanReadDiveSite()
	{
		XmlSerializer serializer = new(typeof(DiveSite));
		DiveSite diveSite = serializer.Deserialize<DiveSite>(Xml);
		diveSite.DiveBases.Count.ShouldBe(3);
		diveSite.Sites.Count.ShouldBe(3);
	}
}
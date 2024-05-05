using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class AlcoholBeforeDiveTests
{
	private const string Xml = """
	                           <alcoholbeforedive>
	                           <!-- if <medicationbeforedive> is given at least one <medicine> section must appear -->
	                               <drink>
	                                   <name>Tequila Sunrise</name>
	                                   <!-- not periodically taken -->
	                                   <periodicallytaken>no</periodicallytaken>
	                                   <!-- taken an hour before the dive -->
	                                   <timespanbeforedive>3600.0</timespanbeforedive>
	                                   <!-- no additional comments concerning this drink -->
	                               </drink>
	                               <drink>
	                                   <!-- here description of another drink had before the dive -->
	                               </drink>
	                               <!-- here more descriptions of additional drinks had can follow -->
	                           </alcoholbeforedive>
	                           """;
	
	[Fact]
	public void CanReadAlcoholBeforeDive()
	{
		XmlSerializer serializer = new(typeof(AlcoholBeforeDive));
		AlcoholBeforeDive alcoholBeforeDive = serializer.Deserialize<AlcoholBeforeDive>(Xml);
		alcoholBeforeDive.Drinks.Count.ShouldBe(2);
	}
}
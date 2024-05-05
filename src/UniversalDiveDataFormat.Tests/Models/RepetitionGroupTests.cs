using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class RepetitionGroupTests
{
	private const string Xml = """
	                           <repetitiongroup id="rg1">
	                               <dive id="dive1">
	                                   <!-- here statements for the first dive -->
	                                   <!-- (should have an "infinite" surface interval) -->
	                                   <surfaceintervalbeforedive>
	                                       <infinity/>
	                                   </surfaceintervalbeforedive>
	                               </dive>
	                               <dive id="dive2">
	                                   <!-- here statements for the second dive -->
	                                   <!-- (should have a finite surface interval) -->
	                               </dive>
	                               <dive id="dive3">
	                                   <!-- here statements for the third dive -->
	                                   <!-- (should have a finite surface interval) -->
	                               </dive>
	                               <!-- here more dives can be placed -->
	                           </repetitiongroup>
	                           """;
	
	[Fact]
	public void CanReadRepetitionGroup()
	{
		XmlSerializer serializer = new(typeof(RepetitionGroup));
		RepetitionGroup repetitionGroup = serializer.Deserialize<RepetitionGroup>(Xml);
		repetitionGroup.Id.ShouldBe("rg1");
		repetitionGroup.Dives.Count.ShouldBe(3);
	}
}
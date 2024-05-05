using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class InputProfileTests
{
	private const string Xml = """
	                           <inputprofile>
	                               <!-- every dive begins at 0 min at the surface! :-) -->
	                               <waypoint>
	                                   <depth>0.0</depth>
	                                   <divetime>0.0</divetime>
	                               </waypoint>
	                               <!-- descent within 5 min to 80 m -->
	                               <waypoint>
	                                   <depth>80.0</depth>
	                                   <divetime>300.0</divetime>
	                               </waypoint>
	                               <!-- stay 5 min at a depth of 80 m -->
	                               <waypoint>
	                                   <depth>80.0</depth>
	                                   <divetime>600.0</divetime>
	                               </waypoint>
	                               <!-- moving up to 70 m within 1 min -->
	                               <waypoint>
	                                   <depth>70.0</depth>
	                                   <divetime>660.0</divetime>
	                               </waypoint>
	                               <!-- remaining at 70m for 5 min -->
	                               <waypoint>
	                                   <depth>70.0</depth>
	                                   <divetime>960.0</divetime>
	                               </waypoint>
	                               <!-- moving down to 75 m in 1 min-->
	                               <waypoint>
	                                   <depth>75.0</depth>
	                                   <divetime>1020.0</divetime>
	                               </waypoint>
	                               <!-- stay at 75 m for another 10 min -->
	                               <waypoint>
	                                   <depth>75.0</depth>
	                                   <divetime>1620.0</divetime>
	                               </waypoint>
	                               <!-- now the ascent begins, for which the software calculates a profile -->
	                           </inputprofile>
	                           """;
	
	[Fact]
	public void CanReadInputProfile()
	{
		XmlSerializer serializer = new(typeof(InputProfile));
		InputProfile inputProfile = serializer.Deserialize<InputProfile>(Xml);
		inputProfile.Waypoints.Count.ShouldBe(7);
	}
}
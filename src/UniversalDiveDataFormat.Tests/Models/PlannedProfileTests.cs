using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class PlannedProfileTests
{
	private const string Xml = """
	                           <plannedprofile  startmix="air" startdivemode="opencircuit">
	                               <!-- every dive begins at 0 min at the surface! :-) -->
	                               <waypoint>
	                                   <depth>0.0</depth>
	                                   <divetime>0.0</divetime>
	                               </waypoint>
	                               <!-- simple profile: -->
	                               <!-- descent within 5 min to 40 m -->
	                               <waypoint>
	                                   <depth>40.0</depth>
	                                   <divetime>300.0</divetime>
	                               </waypoint>
	                               <!-- at this depth it is planned to stay for 10 min -->
	                               <waypoint>
	                                   <depth>40.0</depth>
	                                   <divetime>900.0</divetime>
	                               </waypoint>
	                               <!-- ascent to 10 m within 10 min -->
	                               <waypoint>
	                                   <depth>10.0</depth>
	                                   <divetime>1500.0</divetime>
	                               </waypoint>
	                               <!-- staying at a depth of 10 m for 10 min -->
	                               <waypoint>
	                                   <depth>10.0</depth>
	                                   <divetime>2100.0</divetime>
	                               </waypoint>
	                               <!-- ascent to 3 m within 5 min -->
	                               <waypoint>
	                                   <depth>3.0</depth>
	                                   <divetime>2400.0</divetime>
	                               </waypoint>
	                               <!-- staying at 3 m for 5 min -->
	                               <waypoint>
	                                   <depth>3.0</depth>
	                                   <divetime>2700.0</divetime>
	                               </waypoint>
	                               <!-- ascent to surface within 2 min -->
	                               <waypoint>
	                                   <depth>0.0</depth>
	                                   <divetime>2820.0</divetime>
	                               </waypoint>
	                           </plannedprofile>
	                           """;
	
	[Fact]
	public void CanReadPlannedProfile()
	{
		XmlSerializer serializer = new(typeof(PlannedProfile));
		PlannedProfile plannedProfile = serializer.Deserialize<PlannedProfile>(Xml);
		plannedProfile.StartDiveMode.ShouldBe(StartDiveMode.OpenCircuit);
		plannedProfile.StartMixId.ShouldBe("air");
		plannedProfile.Waypoints.Count.ShouldBe(8);
	}
}
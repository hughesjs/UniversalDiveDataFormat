using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class WaypointTests
{
	private const string Xml = """
	                           <waypoint>
	                               <depth>0.0</depth>
	                               <divetime>0.0</divetime>
	                               <switchmix ref="air"/>
	                           </waypoint>
	                           """;
	
	[Fact]
	public void CanReadWaypoint()
	{
		XmlSerializer serializer = new(typeof(Waypoint));
		Waypoint waypoint = serializer.Deserialize<Waypoint>(Xml);
		waypoint.DepthInMeters.ShouldBe(0.0f);
		waypoint.DiveTimeInSeconds.ShouldBe(0.0f);
		waypoint.SwitchMix!.Ref.ShouldBe("air");
	}
}
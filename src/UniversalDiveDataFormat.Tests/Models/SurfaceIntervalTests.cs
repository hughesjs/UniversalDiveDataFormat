using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SurfaceIntervalTests
{
	private const string Xml = """
	                           <surfaceintervalafterdive>
	                                 <!-- until 1 h after end of dive prolonged staying at place -->
	                                 <passedtime>3600.0</passedtime>
	                                 <!-- now going by car to the next lake -->
	                                 <!-- after 10 min of driving the valley is reached -->
	                                 <wayaltitude waytime="4200.0">500.0</wayaltitude>
	                                 <!-- 5 min driving in the valley -->
	                                 <wayaltitude waytime="4500.0">500.0</wayaltitude>
	                                 <!-- 30 min later a pass is reached -->
	                                 <wayaltitude waytime="6300.0">1250.0</wayaltitude>
	                                 <!-- 5 min enjoying the viewpoint ... -->
	                                 <wayaltitude waytime="6600.0">1250.0</wayaltitude>
	                                 <!-- 40 min driving down to the valley -->
	                                 <wayaltitude waytime="9000.0">380.0</wayaltitude>
	                                 <!-- after 20 min the next dive spot at 430.0 m is reached -->
	                                 <wayaltitude waytime="10200.0">430.0</wayaltitude>
	                                 <!-- 30 min preparations until the planned beginning the next dive -->
	                                 <wayaltitude waytime="12000.0">430.0</wayaltitude>
	                           </surfaceintervalafterdive>
	                           """;
				
	[Fact]
	public void CanReadSurfaceIntervalAfterDive()
	{
		XmlSerializer serializer = new(typeof(SurfaceIntervalAfterDive));
		SurfaceIntervalAfterDive surfaceIntervalAfterDive = serializer.Deserialize<SurfaceIntervalAfterDive>(Xml);
		surfaceIntervalAfterDive.PassedTimeInSeconds.ShouldBe(3600.0f);
		surfaceIntervalAfterDive.WayAltitudes.Count.ShouldBe(7);
	}
}
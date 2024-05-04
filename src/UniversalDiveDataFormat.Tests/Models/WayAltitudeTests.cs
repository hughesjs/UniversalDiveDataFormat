using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class WayAltitudeTests
{
	private const string Xml = """
	                           <wayaltitude waytime="2700.0">700.0</wayaltitude>
	                           """;
	
	[Fact]
	public void CanReadWayAltitude()
	{
		XmlSerializer serializer = new(typeof(WayAltitude));
		WayAltitude wayAltitude = serializer.Deserialize<WayAltitude>(Xml);
		wayAltitude.WayTimeInSeconds.ShouldBe(2700.0f);
		wayAltitude.AltitudeInMeters.ShouldBe(700.0f);
	}
}
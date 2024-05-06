using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ExposureToAltitudeTests
{
	private const string Xml = """
	                           <exposuretoaltitude>
	                               <!-- surface interval between end of dive and begin of flight 2 h -->
	                               <surfaceintervalbeforealtitudeexposure>7200.0</surfaceintervalbeforealtitudeexposure>
	                               <!-- flight with a helicopter -->
	                               <transportation>helicopter</transportation>
	                               <!-- flight on Friday, December 16th, 2005 -->
	                               <dateofflight>
	                                   <datetime>2005-12-16</datetime>
	                               </dateofflight>
	                               <!-- pressure in the cabin corresponds to a (flight) height of 2000 m -->
	                               <!-- (because of helicopter transportation, here flight height) -->
	                               <altitudeofexposure>2000.0</altitudeofexposure>
	                               <!-- flight period 35 min -->
	                               <totallengthofexposure>2100.0</totallengthofexposure>
	                           </exposuretoaltitude>
	                           """;
	
	[Fact]
	public void CanReadExposureToAltitude()
	{
		XmlSerializer serializer = new(typeof(ExposureToAltitude));
		ExposureToAltitude exposureToAltitude = serializer.Deserialize<ExposureToAltitude>(Xml);
		exposureToAltitude.SurfaceIntervalBeforeAltitudeExposureInSeconds.ShouldBe(7200.0f);
		exposureToAltitude.Transportation.ShouldBe(TransportationType.Helicopter);
		exposureToAltitude.DateOfFlight.ShouldNotBeNull();
		exposureToAltitude.AltitudeOfExposureInMeters.ShouldBe(2000.0f);
		exposureToAltitude.TotalLengthOfExposureInSeconds.ShouldBe(2100.0f);
	}
}
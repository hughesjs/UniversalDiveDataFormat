using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class GeographyTests
{
	private const string Xml = """
	                           <geography>
	                               <address>
	                                   <country>Scotland</country>
	                                   <province>Orkney</province>
	                               </address>
	                               <location>Scapa Flow</location>
	                               <!-- latitude: North > 0 / South < 0 -->
	                               <latitude>58.897222</latitude>
	                               <!-- longitude: East > 0 / West < 0 -->
	                               <longitude>-3.1519444</longitude>
	                               <altitude>0.1</altitude>
	                               <!-- Difference to UTC in hours -->
	                               <timezone>1.2</timezone>
	                           </geography>
	                           """;
	
	[Fact]
	public void CanReadGeography()
	{
		XmlSerializer serializer = new(typeof(Geography));
		Geography geography = serializer.Deserialize<Geography>(Xml);
		geography.Address.ShouldNotBeNull();
		geography.Location.ShouldNotBeNull();
		geography.LatitudeInDegreesNorth.ShouldBe(58.897222f);
		geography.LongitudeInDegreesEast.ShouldBe(-3.1519444f);
		geography.AltitudeInMeters.ShouldBe(0.1f);
		geography.TimeZoneOffsetFromUtcInHours.ShouldBe(1.2m);
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class InformationBeforeDiveTests
{
	private const string Xml = """
	                           <informationbeforedive>
	                               <link ref="site_IllesMedes_coast_archway"/>
	                               <divenumber>234</divenumber>
	                               <internaldivenumber>147</internaldivenumber>          <!-- with this dive computer only 147 dives were made -->
	                               <airtemperature>297.15</airtemperature>               <!-- 24 °C -->
	                               <datetime>1999-04-06T16:21:00</datetime>
	                               <alcoholbeforedive>
	                                   <!-- here information concerning drinks taken before the dive -->
	                               </alcoholbeforedive>
	                               <link ref="buehlmann_zhl16"/>                         <!-- decompression model used: Bühlmann ZH-L16 -->
	                               <surfaceintervalbeforedive>
	                                   <passedtime>9000.0</passedtime>
	                               </surfaceintervalbeforedive>
	                               <altitude>0.0</altitude>
	                               <surfacepressure>103000.0</surfacepressure>           <!-- 1030 mbar -->
	                               <platform>charter-boat</platform>
	                               <apparatus>open-scuba</apparatus>
	                               <purpose>sightseeing</purpose>
	                               <stateofrestbeforedive>rested</stateofrestbeforedive>
	                               <tripmembership>Estartit 1999</tripmembership>
	                           </informationbeforedive>
	                           """;
	
	[Fact]
	public void CanReadInformationBeforeDive()
	{
		XmlSerializer serializer = new(typeof(InformationBeforeDive));
		InformationBeforeDive informationBeforeDive = serializer.Deserialize<InformationBeforeDive>(Xml);
		informationBeforeDive.AirTemperatureInKelvin.ShouldBe(297.15f);
		informationBeforeDive.DateTime.ShouldBe(new DateTime(1999, 4, 6, 16, 21, 0));
		informationBeforeDive.DiveNumber.ShouldBe("234");
		informationBeforeDive.InternalDiveNumber.ShouldBe("147");
		informationBeforeDive.Platform.ShouldBe(PlatformType.CharterBoat);
		informationBeforeDive.Purpose.ShouldBe(PurposeType.Sightseeing);	
		informationBeforeDive.StateOfRestBeforeDive.ShouldBe(StateOfRestBeforeDive.Rested);
		informationBeforeDive.TripMembership.ShouldBe("Estartit 1999");
		informationBeforeDive.Apparatus.ShouldBe(Apparatus.OpenScuba);
		informationBeforeDive.AlcoholBeforeDive.ShouldNotBeNull();
	}
}
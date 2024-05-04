using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DiveTests
{
	private const string Xml = """
	                           <dive id="dive_123_19990406">
	                               <informationbeforedive>
	                                   <link ref="site_IllesMedes_coast_archway"/>
	                                   <divenumber>123</divenumber>
	                                   <internaldivenumber>77</internaldivenumber>           <!-- with this dive computer only 77 dives were made -->
	                                   <airtemperature>296.15</airtemperature>               <!-- 23 °C -->
	                                   <datetime>1999-04-06T16:21:00</datetime>
	                                   <surfaceintervalbeforedive>
	                                       <passedtime>17580.0</passedtime>
	                                   </surfaceintervalbeforedive>
	                                   <altitude>0.0</altitude>
	                                   <platform>charter-boat</platform>
	                                   <apparatus>open-scuba</apparatus>
	                                   <purpose>sightseeing</purpose>
	                                   <stateofrestbeforedive>rested</stateofrestbeforedive>
	                               </informationbeforedive>
	                               <tankdata>
	                                   <!-- here quantitative data about breathing gas used (tank, -->
	                                   <!-- pressure, gas, breathing gas consumption volume, etc.) -->
	                               </tankdata>
	                               <!-- here references to breathing gases used -->
	                               <samples>
	                                   <!-- here time/depth data of the profile -->
	                               </samples>
	                               <informationafterdive>
	                                   <lowesttemperature>285.2</lowesttemperature>
	                                   <greatestdepth>25.8</greatestdepth>
	                                   <visibility>10.0</visibility>
	                                   <current>very-mild-current</current>
	                                   <diveplan>dive-computer</diveplan>
	                                   <equipmentmalfunction>none</equipmentmalfunction>
	                                   <pressuredrop>16000000.0</pressuredrop>               <!-- 160 bar -->
	                                   <problems>equalisation</problems>
	                                   <program>recreation</program>
	                                   <thermalcomfort>comfortable</thermalcomfort>
	                                   <workload>light</workload>
	                                   <desaturationtime>63840.0</desaturationtime>          <!-- 17 h 44 min -->
	                                   <noflighttime>34200.0</noflighttime>                  <!--  9 h 30 min -->
	                                   <notes>
	                                       <para>
	                                           <!-- here text written into the logbook -->
	                                       </para>
	                                       <link ref="img_from_dive123"/>
	                                       <!-- here any number of images, audio, and video files can be inserted via <link ref="..."/>  -->
	                                   </notes>
	                                   <!-- personal rating of the dive -->
	                                   <rating>
	                                       <!-- There is no need to set the date of the rating, -->
	                                       <!-- for the dive will normally be rated only once :-) -->
	                                       <!-- and the date is given above. -->
	                                       <ratingvalue>5</ratingvalue>
	                                   </rating>
	                               </informationafterdive>
	                               <applicationdata>
	                                   <randomdata>123456789</randomdata>
	                               </applicationdata>
	                           </dive>
	                           """;
	
	[Fact]
	public void CanReadDive()
	{
		XmlSerializer serializer = new(typeof(Dive));
		Dive dive = serializer.Deserialize<Dive>(Xml);
		dive.Id.ShouldBe("dive_123_19990406");
		dive.InformationAfterDive.ShouldNotBeNull();
		dive.InformationBeforeDive.ShouldNotBeNull();
		dive.Links.Count.ShouldBe(0);
		dive.Samples.ShouldNotBeNull();
		dive.TankData.ShouldNotBeNull();
		dive.ApplicationData.ShouldNotBeNull();
	}
}
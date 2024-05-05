using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class InformationAfterDiveTests
{
	private const string Xml = """
	                           <informationafterdive>
	                               <anysymptoms>
	                                   <!-- here description of possibly occurred DCS symptoms -->
	                               </anysymptoms>
	                               <lowesttemperature>285.2</lowesttemperature>
	                               <greatestdepth>25.8</greatestdepth>
	                               <visibility>10.0</visibility>
	                               <current>very-mild-current</current>
	                               <divetable>BSAC</divetable>
	                               <diveduration>3900.0</diveduration>                   <!-- duration of dive 65 min -->
	                               <averagedepth>15.2</averagedepth>
	                               <diveplan>dive-computer</diveplan>
	                               <highestpo2>16000000.0</highestpo2>
	                               <equipmentused>
	                                   <!-- here information concerning the equipment used with this dive -->
	                               </equipmentused>
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
	                           """;
	
	[Fact]
	public void CanReadInformationAfterDive()
	{
		XmlSerializer serializer = new(typeof(InformationAfterDive));
		InformationAfterDive informationAfterDive = serializer.Deserialize<InformationAfterDive>(Xml);
		informationAfterDive.AnySymptoms.ShouldNotBeNull();
		informationAfterDive.AverageDepthInMeters.ShouldBe(15.2f);
		informationAfterDive.Current.ShouldBe(Current.VeryMildCurrent);
		informationAfterDive.DesaturationTimeInSeconds.ShouldBe(63840.0f);
		informationAfterDive.DiveDurationInSeconds.ShouldBe(3900.0f);
		informationAfterDive.DivePlan.ShouldBe(DivePlanType.DiveComputer);
		informationAfterDive.DiveTable.ShouldNotBeNull();
		informationAfterDive.EquipmentMalfunctions.Single().ShouldBe(EquipmentMalfunction.None);
		informationAfterDive.EquipmentUsed.ShouldNotBeNull();
		informationAfterDive.GlobalAlarmsGiven.ShouldBeNull();
		informationAfterDive.GreatestDepthInMeters.ShouldBe(25.8f);
		informationAfterDive.HighestPartialPressureOfO2InPascals.ShouldBe(16000000.0f);
		informationAfterDive.LowestTemperatureInKelvin.ShouldBe(285.2f);
		informationAfterDive.NoFlightTimeInSeconds.ShouldBe(34200.0f);
		informationAfterDive.Notes.ShouldNotBeNull();
		informationAfterDive.Observations.ShouldBeNull();
		informationAfterDive.PressureDropInPascals.ShouldBe(16000000.0f);
		informationAfterDive.Problems.Count.ShouldBe(1);
		informationAfterDive.Program.ShouldBe(ProgramType.Recreation);
		informationAfterDive.Ratings.Count.ShouldBe(1);
		informationAfterDive.SurfaceIntervalAfterDive.ShouldBeNull();
		informationAfterDive.ThermalComfort.ShouldBe(ThermalComfortType.Comfortable);
		informationAfterDive.VisibilityInMeters.ShouldBe(10.0f);
		informationAfterDive.Workload.ShouldBe(WorkloadType.Light);
	}		
}
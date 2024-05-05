using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ProfileTests
{
	private const string Xml = """
	                           <profile id="beispiel_profil">
	                               <applicationdata><thespanishinquisition/></applicationdata>
	                               <surfaceintervalbeforedive>
	                                   <!-- 1. dive - no repetitive dive -->
	                                   <passedtime>infinity</passedtime>
	                               </surfaceintervalbeforedive>
	                               <!-- fresh water -->
	                               <density>1000.0</density>
	                               <!-- max. ascending rate 5 m/min -->
	                               <maximumascendingrate>0.083333333333</maximumascendingrate>
	                               <output>
	                                   <lingo>en</lingo>
	                                   <fileformat>pdf</fileformat>
	                                   <filename>RonsProfile</filename>
	                                   <headline>Ron's 100 m Trimix Deep Dive</headline>
	                                   <remark>
	                                       This is an ascent profile especially generated for Ron's 100 m
	                                       Trimix Dive on Sunday.
	                                   </remark>
	                               </output>
	                               <mixchange>
	                                   <!-- Note: All breathing gases must be declared inside the <gasdefinitions> section -->
	                                   <!-- - otherwise the UDDF parser has to bring up an error message. -->
	                                   <!-- changes of breathing gases during descent -->
	                                   <descent>
	                                       <waypoint>
	                                           <!-- beginning dive with Nitrox NOAA I (32 % O2, 68 % N2) -->
	                                           <depth>0.0</depth>
	                                           <switchmix ref="noaa1"/>
	                                       </waypoint>
	                                       <waypoint>
	                                           <!-- at a depth of 35 m switch over to Trimix -->
	                                           <depth>35.0</depth>
	                                           <switchmix ref="trimix"/>
	                                       </waypoint>
	                                       <waypoint>
	                                           <!-- at 80 m switch over to Heliox -->
	                                           <depth>80.0</depth>
	                                           <switchmix ref="heliox"/>
	                                       </waypoint>
	                                   </descent>
	                                   <!-- changes of breathing gases during the following ascent -->
	                                   <ascent>
	                                       <waypoint>
	                                           <depth>85.0</depth>
	                                           <switchmix ref="trimix"/>
	                                       <(waypoint>
	                                       <waypoint>
	                                           <depth>40.0</depth>
	                                           <switchmix ref="noaa1"/>
	                                       </waypoint>
	                                       <waypoint>
	                                           <depth>5.0</depth>
	                                           <switchmix ref="oxygen"/>
	                                       </waypoint>
	                                   </ascent>
	                               </mixchange>
	                               <!-- set data for the descent profile, on whose basis the ascent profile shall be calculated -->
	                               <inputprofile>
	                                   <waypoint>
	                                       <!-- every dive begins at 0 min at the surface :-) -->
	                                       <depth>0.0</depth>
	                                       <divetime>0.0</divetime>
	                                   </waypoint>
	                                   <waypoint>
	                                       <!-- simple profile: -->
	                                       <!-- descent within 5 min to 100 m -->
	                                       <depth>100.0</depth>
	                                       <divetime>300.0</divetime>
	                                   </waypoint>
	                                   <waypoint>
	                                       <!-- remain at this depth for 10 min -->
	                                       <depth>100.0</depth>
	                                       <divetime>900.0</divetime>
	                                   </waypoint>
	                                   <!-- now the ascent begins, for which the software calculates the profile -->
	                               </inputprofile>
	                           </profile>
	                           """;
	
	[Fact]
	public void CanReadProfile()
	{
		XmlSerializer serializer = new(typeof(Profile));
		Profile profile = serializer.Deserialize<Profile>(Xml);
		profile.SurfaceIntervalBeforeDive.ShouldNotBeNull();
		profile.DensityInKgPerMeterCubed.ShouldBe(1000.0f);
		profile.MaximumAscendingRateInCubicMetersPerSecond.ShouldBe(0.083333333333f);
		profile.Output.ShouldNotBeNull();
		profile.MixChange.ShouldNotBeNull();
		profile.InputProfile.ShouldNotBeNull();
		profile.Id.ShouldBe("beispiel_profil");
		profile.ApplicationData.ShouldNotBeNull();
	}
}
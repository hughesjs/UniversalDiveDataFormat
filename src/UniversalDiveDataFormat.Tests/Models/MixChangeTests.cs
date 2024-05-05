using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MixChangeTests
{
	private const string Xml = """
	                           <mixchange>
	                               <ascent>
	                                   <waypoint>
	                                       <depth>80.0</depth>
	                                       <switchmix ref="Trimix2"/>
	                                   </waypoint>
	                                   <waypoint>
	                                       <depth>50.0</depth>
	                                       <switchmix ref="Trimix1"/>
	                                   </waypoint>
	                                   <waypoint>
	                                       <depth>35.0</depth>
	                                       <switchmix ref="Nitrox4060"/>
	                                   <depth switchmix="Nitrox4060">35.0</depth>
	                                   </waypoint>
	                                   <waypoint>
	                                       <depth>15.0</depth>
	                                       <switchmix ref="Nitrox2080"/>
	                                   </waypoint>
	                                   <waypoint>
	                                       <depth>5.0</depth>
	                                       <switchmix ref="oxygen"/>
	                                   </waypoint>
	                               </ascent>
	                               <descent>
	                               <waypoint>
	                                   <depth>80.0</depth>
	                                   <switchmix ref="Trimix2"/>
	                               </waypoint>
	                               <waypoint>
	                                   <depth>50.0</depth>
	                                   <switchmix ref="Trimix1"/>
	                               </waypoint>
	                               <waypoint>
	                                   <depth>35.0</depth>
	                                   <switchmix ref="Nitrox4060"/>
	                               <depth switchmix="Nitrox4060">35.0</depth>
	                               </waypoint>
	                               <waypoint>
	                                   <depth>15.0</depth>
	                                   <switchmix ref="Nitrox2080"/>
	                               </waypoint>
	                               <waypoint>
	                                   <depth>5.0</depth>
	                                   <switchmix ref="oxygen"/>
	                               </waypoint>
	                               </descent>
	                           </mixchange>
	                           """;
	
	[Fact]
	public void CanReadMixChange()
	{
		XmlSerializer serializer = new(typeof(MixChange));
		MixChange mixChange = serializer.Deserialize<MixChange>(Xml);
		mixChange.Ascent.Waypoints.Count.ShouldBe(5);
		mixChange.Descent!.Waypoints.Count.ShouldBe(5);
	}
}
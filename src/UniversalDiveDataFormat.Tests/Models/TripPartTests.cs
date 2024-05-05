using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TripPartTests
{
	private const string Xml = """
	                           <trippart type="boattrip, organizedtrip">
	                               <name>Dive club trip to Corse 2005 - 1 week Galiote</name>
	                               <dateoftrip startdate="2005-05-21" enddate="2005-05-28"/>
	                               <geography>
	                                   <location>Mediterranean Sea</location>
	                                   <address>
	                                       <country>Corse</country>
	                                   </address>
	                               </geography>
	                               <vessel>
	                                   <name>Galiote</name>
	                                   <shiptype>motoryacht</shiptype>
	                                   <!-- no other data available -->
	                               </vessel>
	                               <relateddives>
	                                   <link ref="dive_580"/><link ref="dive_581"/><link ref="dive_582"/><link ref="dive_583"/>
	                                   <link ref="dive_584"/><link ref="dive_585"/><link ref="dive_586"/><link ref="dive_587"/>
	                                   <link ref="dive_588"/><link ref="dive_589"/><link ref="dive_590"/><link ref="dive_591"/>
	                               </relateddives>
	                               <notes>
	                                   <para>Nice diving holiday with Günter and his crew!</para>
	                                   <link ref="video_galiote2005"/>
	                               </notes>
	                           </trippart>
	                           """;
	
	[Fact]
	public void CanReadTripPart()
	{
		XmlSerializer serializer = new(typeof(TripPart));
		TripPart tripPart = serializer.Deserialize<TripPart>(Xml);
		tripPart.Name.ShouldBe("Dive club trip to Corse 2005 - 1 week Galiote");
		tripPart.DateOfTrip.ShouldNotBeNull();
		tripPart.Geography.ShouldNotBeNull();
		tripPart.Vessel.ShouldNotBeNull();
		tripPart.RelatedDives.ShouldNotBeNull();
		tripPart.Notes.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TripTests
{
	private const string Xml = """
	                           <trip id="trip_holiday2005">
	                               <name>Dive club trip to Corse 2005</name>
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
	                               <trippart type="individualtrip">
	                                   <name>Dive club trip to Corse 2005 - 1 week campingground and dive club Nemo</name>
	                                   <dateoftrip startdate="2005-05-28" enddate="2005-06-05"/>
	                                   <geography>
	                                       <address>
	                                           <country>Corse</country>
	                                       </address>
	                                   </geography>
	                                   <accommodation>
	                                       <name>Camping Corse</name>
	                                       <category>camping</category>
	                                       <contact>
	                                           <email>info@camping-corse.com</email>
	                                           <homepage>http://www.camping-corse.com</homepage>
	                                       </contact>
	                                       <rating>
	                                           <ratingvalue>6</ratingvalue>
	                                       </rating>
	                                   </accommodation>
	                                   <relateddives>
	                                       <link ref="dive_592"/><link ref="dive_593"/><link ref="dive_594"/><link ref="dive_595"/>
	                                       <link ref="dive_596"/><link ref="dive_597"/><link ref="dive_598"/><link ref="dive_599"/>
	                                       <link ref="dive_600"/><link ref="dive_601"/><link ref="dive_602"/><link ref="dive_603"/>
	                                   </relateddives>
	                                   <notes>
	                                       <para>Nice second week of the diving holiday!</para>
	                                       <link ref="video_corse2005"/>
	                                   </notes>
	                               </trippart>
	                           </trip>
	                           """;
	
	[Fact]
	public void CanReadTrip()
	{
		XmlSerializer serializer = new(typeof(Trip));
		Trip trip = serializer.Deserialize<Trip>(Xml);
		trip.Id.ShouldBe("trip_holiday2005");
		trip.Name.ShouldBe("Dive club trip to Corse 2005");
		trip.TripParts.Count.ShouldBe(2);
	}
}
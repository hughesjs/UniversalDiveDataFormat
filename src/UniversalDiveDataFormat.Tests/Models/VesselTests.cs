using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class VesselTests
{
	private const string Xml = """
	                           <vessel>
	                               <name>Hexagone</name>
	                               <shiptype>sailing yacht</shiptype>
	                               <marina>Marine de Cogolin</marina>
	                               <address>
	                                   <!-- here address data of the charterer -->
	                               </address>
	                               <contact>
	                                   <!-- here further contact data of the charterer (email, homepage, phone etc.) -->
	                               </contact>
	                               <shipdimension>
	                                   <!-- only the length is known in this case -->
	                                   <length>15.0</length>
	                               </shipdimension>
	                               <rating>
	                                   <ratingvalue>8</ratingvalue>
	                               </rating>
	                               <notes>
	                                   <para>
	                                       beautiful 15m sailing yacht
	                                   </para>
	                                   <link ref="img_hexagone1"/>
	                                   <link ref="img_hexagone2"/>
	                                   <link ref="img_hexagone_salon"/>
	                               </notes>
	                           </vessel>
	                           """;

	[Fact]
	public void CanReadVessel()
	{
		XmlSerializer serializer = new(typeof(Vessel));
		Vessel vessel = serializer.Deserialize<Vessel>(Xml);
		vessel.Name.ShouldBe("Hexagone");
		vessel.ShipType.ShouldBe("sailing yacht");
		vessel.Marina.ShouldNotBeNull();
		vessel.Address.ShouldNotBeNull();
		vessel.Contact.ShouldNotBeNull();
		vessel.ShipDimension.ShouldNotBeNull();
		vessel.Ratings.Count.ShouldBe(1);
		vessel.Notes.ShouldNotBeNull();
	}
}
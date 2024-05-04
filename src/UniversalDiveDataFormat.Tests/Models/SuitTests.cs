using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SuitTests
{
	private const string Xml = """
	                           <suit id="my_wetty">
	                               <name>Freezing Quickly</name>
	                               <suittype>wet-suit</suittype>
	                               <manufacturer>
	                                   <name>Ice Company</name>
	                               </manufacturer>
	                               <model>5 Degrees</model>
	                               <!-- no serial number -->
	                               <purchase>
	                                   <datetime>1969-03-31</datetime>
	                                   <price currency="DM">300.00</price>
	                                   <shop>
	                                       <name>Dive Deep Down</name>
	                                       <address>
	                                           <!-- address of shop -->
	                                       </address>
	                                       <contact>
	                                           <!-- phone number, email address etc. -->
	                                       </contact>
	                                       <notes>
	                                           <!-- additional remarks -->
	                                       </notes>
	                                   </shop>
	                               </purchase>
	                               <!-- no service interval -->
	                           </suit>
	                           """;
	
	[Fact]
	public void CanReadSuit()
	{
		XmlSerializer serializer = new(typeof(Suit));
		Suit suit = serializer.Deserialize<Suit>(Xml);
		
		suit.Id.ShouldBe("my_wetty");
		suit.Name.ShouldBe("Freezing Quickly");
		suit.Manufacturer.ShouldNotBeNull();
		suit.Model.ShouldBe("5 Degrees");
		suit.Purchase.ShouldNotBeNull();
		suit.SuitType.ShouldBe(SuitType.WetSuit);
	}
}
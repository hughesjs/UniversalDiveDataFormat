using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BootsTests
{
	private const string Xml = """
	                           <boots id="my_boots">
	                               <name>noname</name>
	                               <manufacturer>
	                                   <name>Not Known</name>
	                               </manufacturer>
	                               <model>Size 48</model>
	                               <!-- no serial number in this case :-) -->
	                               <purchase>
	                                   <datetime>1970-10-07</datetime>
	                                   <price currency="DM">10.00</price>
	                                   <shop>
	                                       <name>Not-for-Diving</name>
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
	                               <!-- better wash them once per month... ;-) -->
	                               <serviceinterval>30</serviceinterval>
	                               <!-- a certain service interval does not exist ;-) -->
	                           </boots>
	                           """;
	
	[Fact]
	public void CanReadBoots()
	{
		XmlSerializer serializer = new(typeof(Boots));
		Boots boots = serializer.Deserialize<Boots>(Xml);
		
		boots.Id.ShouldBe("my_boots");
		boots.Name.ShouldBe("noname");
		boots.Manufacturer.ShouldNotBeNull();
		boots.Model.ShouldBe("Size 48");
		boots.Purchase.ShouldNotBeNull();
		boots.ServiceIntervalInDays.ShouldBe(30);
	}
}
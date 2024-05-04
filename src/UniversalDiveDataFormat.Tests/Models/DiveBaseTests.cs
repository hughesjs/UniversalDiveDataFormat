using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DiveBaseTests
{
	private const string Xml = """
	                           <divebase id="db_top-diving">
	                               <name>Top Diving</name>
	                               <address>
	                                   <!-- address of dive base -->
	                               </address>
	                               <contact>
	                                   <!-- email address, homepage of dive base -->
	                               </contact>
	                               <priceperdive currency="EUR">35.0</priceperdive>
	                               <pricedivepackage currency="EUR" noofdives="10">320.0</pricedivepackage>
	                               <guide id="g_Emil_TL2">
	                                   <!-- Guide Emil must be described inside the <buddy> section, -->
	                                   <!-- therefore here only a reference -->
	                                   <link ref="buddy_Emil_TL2"/>
	                               </guide>
	                               <guide id="g_Franka">
	                                   <!-- Guide Franka must be described inside the <buddy> section, -->
	                                   <!-- therefore here only a reference -->
	                                   <link ref="buddy_Franka"/>
	                               </guide>
	                               <rating>
	                                   <ratingvalue>8</ratingvalue>
	                               </rating>
	                               <notes>
	                                   <para>familiar atmosphere, very friendly and obligy</para>
	                               </notes>
	                           </divebase>
	                           """;
	
	[Fact]
	public void CanReadDiveBase()
	{
		XmlSerializer serializer = new(typeof(DiveBase));
		DiveBase diveBase = serializer.Deserialize<DiveBase>(Xml);
		diveBase.Id.ShouldBe("db_top-diving");
		diveBase.Name.ShouldBe("Top Diving");
		diveBase.Address.ShouldNotBeNull();
		diveBase.Contact.ShouldNotBeNull();
		diveBase.PricePerDive.ShouldNotBeNull();
		diveBase.PriceDivePackage.ShouldNotBeNull();
		diveBase.Guides.Count.ShouldBe(2);
		diveBase.Ratings.ShouldNotBeNull();
		diveBase.Notes.ShouldNotBeNull();
	}
}
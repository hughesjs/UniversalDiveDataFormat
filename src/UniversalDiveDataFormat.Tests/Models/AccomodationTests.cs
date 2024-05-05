using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class AccommodationTests
{
	private const string Xml = """
	                           <accommodation>
	                               <name>Hotel of the 1000 Stars</name>
	                               <category>camping</category>
	                               <address>
	                                   <!-- address of hotel/camping ground -->
	                               </address>
	                               <contact>
	                                   <!-- contact data (email address, homepage etc.) of hotel/camping ground -->
	                               </contact>
	                               <rating>
	                                   <datetime>2008-10-23</datetime>
	                                   <ratingvalue>7</ratingvalue>
	                               </rating>
	                               <notes>
	                                   <para>Nice "home" for this week!</para>
	                                   <!-- this cross-referentiation presumes a declaration inside the <mediadata> section-->
	                                   <link ref="img_tent"/>
	                               </notes>
	                           </accommodation>
	                           """;

	[Fact]
	public void CanReadAccommodation()
	{
		XmlSerializer serializer = new(typeof(Accommodation));
		Accommodation accommodation = serializer.Deserialize<Accommodation>(Xml);
		accommodation.Name.ShouldBe("Hotel of the 1000 Stars");
		accommodation.Category.ShouldBe(AccommodationCategory.Camping);
		accommodation.Address.ShouldNotBeNull();
		accommodation.Contact.ShouldNotBeNull();
		accommodation.Ratings.Count.ShouldBe(1);
		accommodation.Notes.ShouldNotBeNull();
	}
}
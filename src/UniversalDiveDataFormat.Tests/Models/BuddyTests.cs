using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BuddyTests
{


	[Fact]
	public void CanReadBuddy()
	{
			const string xml = """
			                   <buddy id="Linda">
			                       <personal>
			                           <firstname>Linda</firstname>
			                           <lastname>Pink</lastname>
			                           <sex>female</sex>
			                           <birthdate>
			                               <year>1974</year>
			                           </birthdate>
			                       </personal>
			                       <address>
			                           <country>Australia</country>
			                       </address>
			                       <contact>
			                           <language>English</language>
			                           <mobilephone>0321/987654</mobilephone>
			                           <fax>0321/987653</fax>
			                           <email>linda.pink@buddybase.org</email>
			                       </contact>
			                       <equipment>
			                           <!-- listing of Linda's equipment -->
			                       </equipment>
			                       <medical>
			                           <!-- listing of Linda's dive medical examinations - if known -->
			                       </medical>
			                       <education>
			                           <certification>
			                               <level>Gold</level>
			                               <organisation>CMAS</organisation>
			                           </certification>
			                       </education>
			                       <notes>
			                           <link ref="img_linda1"/>
			                           <link ref="img_linda2"/>
			                           <link ref="video_by_linda_great_barrier_reef"/>
			                       </notes>
			                   </buddy>
			                   """;
		
		XmlSerializer serializer = new(typeof(Buddy));
		Buddy buddy = serializer.Deserialize<Buddy>(xml);

		buddy.Id.ShouldBe("Linda");
		buddy.Personal.ShouldNotBeNull();
		buddy.Contact.ShouldNotBeNull();
		buddy.Address.ShouldNotBeNull();
		buddy.Education.ShouldNotBeNull();
		buddy.Medical.ShouldNotBeNull();
		buddy.Equipment.ShouldNotBeNull();
		buddy.IsStudent.ShouldBeFalse();
	}
	
	[Fact]
	public void CanReadBuddyWithStudent()
	{
		const string xml = """
		                   <buddy id="Linda">
		                       <student/>
		                   </buddy>
		                   """;
		
		XmlSerializer serializer = new(typeof(Buddy));
		Buddy buddy = serializer.Deserialize<Buddy>(xml);
		buddy.IsStudent.ShouldBeTrue();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class OperatorTests
{
	private const string Xml = """
	                           <operator>
	                               <name>Sunrise Tours</name>
	                               <address>
	                                   <!-- address of operator -->
	                               </address>
	                               <contact>
	                                   <!-- email address, and homepage of operator -->
	                               </contact>
	                               <rating>
	                                   <ratingvalue>1</ratingvalue> <!-- lowest possible rating :-) -->
	                               </rating>
	                               <notes>
	                                   <para>Never again!!!</para>
	                               </notes>
	                           </operator>
	                           """;
	
	[Fact]
	public void CanReadOperator()
	{
		XmlSerializer serializer = new(typeof(Operator));
		Operator op = serializer.Deserialize<Operator>(Xml);
		op.Name.ShouldBe("Sunrise Tours");
		op.Contact.ShouldNotBeNull();
		op.Ratings.Count.ShouldBe(1);
		op.Notes.ShouldNotBeNull();
	}
}
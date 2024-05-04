using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class RatingTests
{
	private const string Xml = """
	                           <rating>
	                               <datetime>2010-08-16</datetime>
	                               <ratingvalue>9</ratingvalue>
	                           </rating>
	                           """;
	
	[Fact]
	public void CanReadRating()
	{
		XmlSerializer serializer = new(typeof(Rating));
		Rating rating = serializer.Deserialize<Rating>(Xml);
		rating.Value.ShouldBe(9);
		rating.DateTime.ShouldBe(new DateTime(2010, 8, 16));
	}
}
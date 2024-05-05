using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DateOfTripTests
{
	private const string Xml = """
	                           <dateoftrip startdate ="2008-05-11" enddate="2008-05-31T15:30:00Z"/>
	                           """;
	
	[Fact]
	public void CanReadDateOfTrip()
	{
		XmlSerializer serializer = new(typeof(DateOfTrip));
		DateOfTrip dateOfTrip = serializer.Deserialize<DateOfTrip>(Xml);
		dateOfTrip.StartDate.ShouldBe(new DateTime(2008, 5, 11));
		dateOfTrip.EndDate.ShouldBe(new DateTime(2008, 5, 31, 15, 30, 0));
	}
}
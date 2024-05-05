using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class NumberOfDivesTests
{
	private const string Xml = """
	                           <numberofdives startdate="2008-02-16" enddate="2009-02-16" dives="123"/>
	                           """;
	
	[Fact]
	public void CanReadNumberOfDives()
	{
		XmlSerializer serializer = new(typeof(NumberOfDives));
		NumberOfDives numberOfDives = serializer.Deserialize<NumberOfDives>(Xml);
		numberOfDives.StartDate.ShouldBe(new DateTime(2008, 2, 16));
		numberOfDives.EndDate.ShouldBe(new DateTime(2009, 2, 16));
		numberOfDives.Dives.ShouldBe(123);
	}
}
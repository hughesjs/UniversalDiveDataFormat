using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class LaunchingDateTests
{
	private const string Xml = """
	                           <launchingdate>
	                               <datetime>1943-06-14</datetime>
	                           </launchingdate>
	                           """;
	
	[Fact]
	public void CanReadLaunchingDate()
	{
		XmlSerializer serializer = new(typeof(LaunchingDate));
		LaunchingDate launchingDate = serializer.Deserialize<LaunchingDate>(Xml);
		launchingDate.DateTime.ShouldBe(new(1943, 6, 14));
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class InsuranceTests
{
	private const string Xml = """
	                           <insurance>
	                               <name>my-easy-dive-insurance</name>
	                               <issuedate>
	                                   <datetime>2002-01-29</datetime>
	                               </issuedate>
	                           </insurance>
	                           """;
	
	[Fact]
	public void CanReadInsurance()
	{
		XmlSerializer serializer = new(typeof(Insurance));
		Insurance insurance = serializer.Deserialize<Insurance>(Xml);
		insurance.Name.ShouldBe("my-easy-dive-insurance");
		insurance.IssueDate.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class PermitTests
{
	private const string Xml = """
	                           <permit>
	                               <name>DiveCard</name>
	                               <region>Austria</region>
	                               <issuedate>
	                                   <datetime>2004-08-24</datetime>
	                               </issuedate>
	                               <validdate>
	                                   <datetime>2005-08-23</datetime>
	                               </validdate>
	                           </permit>
	                           """;
	
	[Fact]
	public void CanReadPermit()
	{
		XmlSerializer serializer = new(typeof(Permit));
		Permit permit = serializer.Deserialize<Permit>(Xml);
		permit.Name.ShouldBe("DiveCard");
		permit.Region.ShouldBe("Austria");
		permit.IssueDate.ShouldNotBeNull();
		permit.ValidDate.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDcDiveSiteDataTests
{
	private const string Xml = """
	                           <setdcdivesitedata divesite="ilot_de_la_gabiniere"/>
	                           """;
	
	[Fact]
	public void CanReadSetDcDiveSiteData()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerDiveSiteData));
		SetDiveComputerDiveSiteData setDcDiveSiteData = serializer.Deserialize<SetDiveComputerDiveSiteData>(Xml);
		setDcDiveSiteData.DiveSiteId.ShouldBe("ilot_de_la_gabiniere");
	}
}
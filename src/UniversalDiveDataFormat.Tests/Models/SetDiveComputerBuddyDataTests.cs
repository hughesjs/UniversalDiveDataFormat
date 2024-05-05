using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerBuddyDataTests
{
	private const string Xml = """<setdcbuddydata buddy="amy"/> """;
	
	[Fact]
	public void CanReadSetDcBuddyData()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerBuddyData));
		SetDiveComputerBuddyData setDcBuddyData = serializer.Deserialize<SetDiveComputerBuddyData>(Xml);
		setDcBuddyData.BuddyId.ShouldBe("amy");
	}
}
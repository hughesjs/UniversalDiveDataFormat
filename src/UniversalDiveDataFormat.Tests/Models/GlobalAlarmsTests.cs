using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class GlobalAlarmsTests
{
	private const string Xml = """
	                           <globalalarmsgiven>
	                               <globalalarm>sos-mode</globalalarm>
	                               <globalalarm>work-too-hard</globalalarm>
	                               <globalalarm>ascent-warning-too-long</globalalarm>
	                           </globalalarmsgiven>
	                           """;
	
	[Fact]
	public void CanReadGlobalAlarmsGiven()
	{
		XmlSerializer serializer = new(typeof(GlobalAlarmsGiven));
		GlobalAlarmsGiven globalAlarmsGiven = serializer.Deserialize<GlobalAlarmsGiven>(Xml);
		globalAlarmsGiven.GlobalAlarms.Count.ShouldBe(3);
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DiveComputerAlarmTests
{
	private const string Xml = """
	                           <dcalarm>
	                               <!-- duration of alarm 10 seconds -->
	                               <period>10.0</period>
	                               <alarmtype>1</alarmtype>
	                               <acknowledge/>
	                           </dcalarm>
	                           """;
	
	[Fact]
	public void CanReadDcAlarm()
	{
		XmlSerializer serializer = new(typeof(DiveComputerAlarm));
		DiveComputerAlarm dcAlarm = serializer.Deserialize<DiveComputerAlarm>(Xml);
		dcAlarm.PeriodInSeconds.ShouldBe(10.0f);
		dcAlarm.AlarmType.ShouldBe(1);
		dcAlarm.Acknowledge.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerAlarmTimeTests
{
	private const string Xml = """
	                           <setdcalarmtime>
	                               <datetime>2022-01-01T14:37:00</datetime>
	                               <dcalarm>
	                                   <!-- duration 10 seconds -->
	                                   <period>10.0</period>
	                                   <alarmtype>1</alarmtype>
	                               </dcalarm>
	                           </setdcalarmtime>
	                           """;
	
	[Fact]
	public void CanReadSetDcAlarmTime()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerAlarmTime));
		SetDiveComputerAlarmTime setDcAlarmTime = serializer.Deserialize<SetDiveComputerAlarmTime>(Xml);
		setDcAlarmTime.DateTime.ShouldBe(new DateTime(2022, 1, 1, 14, 37, 0));
		setDcAlarmTime.DiveComputerAlarm.ShouldNotBeNull();
	}
}
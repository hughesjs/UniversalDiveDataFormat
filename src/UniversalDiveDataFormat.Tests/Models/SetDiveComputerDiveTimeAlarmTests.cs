using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerDiveTimeAlarmTests
{
	private const string Xml = """
	                           <setdcdivetimealarm>
	                               <timespan>3600.0</timespan>
	                               <dcalarm>
	                                   <!-- this alarm is to be acknowledged -->
	                                   <acknowledge/>
	                                   <alarmtype>4</alarmtype>
	                               </dcalarm>
	                           </setdcdivetimealarm>
	                           """;
	
	[Fact]
	public void CanReadSetDcDiveTimeAlarm()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerDiveTimeAlarm));
		SetDiveComputerDiveTimeAlarm setDcDiveTimeAlarm = serializer.Deserialize<SetDiveComputerDiveTimeAlarm>(Xml);
		setDcDiveTimeAlarm.TimeSpanInSeconds.ShouldBe(3600.0f);
		setDcDiveTimeAlarm.DiveComputerAlarm.ShouldNotBeNull();
	}
}
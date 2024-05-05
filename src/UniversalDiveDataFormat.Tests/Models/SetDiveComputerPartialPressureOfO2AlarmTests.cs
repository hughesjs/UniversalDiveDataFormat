using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerPartialPressureOfO2AlarmTests
{
	private const string Xml = """
	                           <setdcdivepo2alarm>
	                               <maximumpo2>1.6</maximumpo2>
	                               <dcalarm>
	                                   <!-- this alarm is to be acknowledged -->
	                                   <acknowledge/>
	                                   <alarmtype>2</alarmtype>
	                               </dcalarm>
	                           </setdcdivepo2alarm>
	                           """;
	
	[Fact]
	public void CanReadSetDcPartialPressureOfO2Alarm()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerPartialPressureOfO2Alarm));
		SetDiveComputerPartialPressureOfO2Alarm setDcPartialPressureOfO2Alarm = serializer.Deserialize<SetDiveComputerPartialPressureOfO2Alarm>(Xml);
		setDcPartialPressureOfO2Alarm.MaximumPartialPressureOfO2InBars.ShouldBe(1.6f);
		setDcPartialPressureOfO2Alarm.DiveComputerAlarm.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerEndNoDecoTimeAlarmTests
{
	private const string Xml = """
	                           <setdcendndtalarm>
	                               <dcalarm>
	                                   <!-- this alarm is to be acknowledged -->
	                                   <acknowledge/>
	                                   <alarmtype>4</alarmtype>
	                               </dcalarm>
	                           </setdcendndtalarm>
	                           """;
	
	[Fact]
	public void CanReadSetDcEndNoDecoTimeAlarm()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerEndNoDecoTimeAlarm));
		SetDiveComputerEndNoDecoTimeAlarm setDcEndNoDecoTimeAlarm = serializer.Deserialize<SetDiveComputerEndNoDecoTimeAlarm>(Xml);
		setDcEndNoDecoTimeAlarm.DiveComputerAlarm.ShouldNotBeNull();
	}
}
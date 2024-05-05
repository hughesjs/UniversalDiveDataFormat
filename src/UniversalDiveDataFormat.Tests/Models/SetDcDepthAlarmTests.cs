using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDcDepthAlarmTests
{
	private const string Xml = """
	                           <setdcdivedepthalarm>
	                               <dcalarmdepth>40.0</dcalarmdepth>
	                               <dcalarm>
	                                   <!-- this alarm is to be acknowledged -->
	                                   <acknowledge/>
	                                   <alarmtype>2</alarmtype>
	                               </dcalarm>
	                           </setdcdivedepthalarm>
	                           """;
	
	[Fact]
	public void CanReadSetDcDepthAlarm()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerDiveDepthAlarm));
		SetDiveComputerDiveDepthAlarm setDcDepthAlarm = serializer.Deserialize<SetDiveComputerDiveDepthAlarm>(Xml);
		setDcDepthAlarm.DiveComputerAlarmDepthInMeters.ShouldBe(40.0f);
		setDcDepthAlarm.DiveComputerAlarm.ShouldNotBeNull();
	}	
}
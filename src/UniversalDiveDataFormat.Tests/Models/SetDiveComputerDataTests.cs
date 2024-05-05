using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SetDiveComputerDataTests
{
	private const string Xml = """
	                           <setdcdata>
	                               <!-- set date and time -->
	                               <setdcdatetime>
	                                   <datetime>2007-08-24T09:00:00</datetime>
	                               </setdcdatetime>
	                               <!-- set the decompression model to be used -->
	                               <setdcdecomodel>
	                                   <name>RGBM</name>
	                                   <applicationdata>
	                                       <!-- here additional data by the manufacturer to be used with the given deco model -->
	                                   </applicationdata>
	                               </setdcdecomodel>
	                               <!-- set the breathing gase/s to be used -->
	                               <setdcgasdefinitionsdata/>
	                               <!-- set an alarm to be given if end of no-decompression time is reached -->
	                               <setdcendndtalarm>
	                                   <dcalarm>
	                                       <!-- alarm is to be acknowledged -->
	                                       <acknowledge/>
	                                       <alarmtype>2</alarmtype>
	                                   </dcalarm>
	                               </setdcendndtalarm>
	                               <!-- transfer data of dive buddy Alfons to the dive computer -->
	                               <setdcbuddydata buddy="alfons"/>
	                           </setdcdata>
	                           """;
	
	[Fact]
	public void CanReadSetDcData()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerData));
		SetDiveComputerData setDcData = serializer.Deserialize<SetDiveComputerData>(Xml);
		setDcData.SetDiveComputerDateTime.ShouldNotBeNull();
		setDcData.SetDiveComputerDecoModel.ShouldNotBeNull();
		setDcData.SetDiveComputerGasDefinitionsData.ShouldNotBeNull();
		setDcData.SetDiveComputerEndNoDecoTimeAlarm.ShouldNotBeNull();
		setDcData.SetDiveComputerBuddyData.ShouldNotBeNull();
	}
}
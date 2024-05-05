using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TankTests
{
	private const string Xml = """
	                           <tank id="my_tank">
	                               <name>Albert's tank</name>
	                               <manufacturer>
	                                   <name>Steeltankmaker</name>
	                               </manufacturer>
	                               <model>15 litres</model>
	                               <serialnumber>12345</serialnumber>
	                               <tankvolume>0.015</tankvolume>
	                               <purchase>
	                                   <datetime>1986-08-19</datetime>
	                                   <price currency="DM">200.00</price>
	                                   <shop>
	                                       <name>Dive Deep Down</name>
	                                       <address>
	                                           <!-- address of shop -->
	                                       </address>
	                                       <contact>
	                                           <!-- phone number, email address etc. -->
	                                       </contact>
	                                       <notes>
	                                           <!-- additional remarks -->
	                                       </notes>
	                                   </shop>
	                               </purchase>
	                               <!-- every two years to be serviced -->
	                               <serviceinterval>730</serviceinterval>
	                               <nextservicedate>
	                                   <datetime>2006-08</datetime>
	                               </nextservicedate>
	                           </tank>
	                           """;
	
	[Fact]
	public void CanReadTank()
	{
		XmlSerializer serializer = new(typeof(Tank));
		Tank tank = serializer.Deserialize<Tank>(Xml);
		
		tank.Id.ShouldBe("my_tank");
		tank.Name.ShouldBe("Albert's tank");
		tank.Manufacturer.ShouldNotBeNull();
		tank.Model.ShouldBe("15 litres");
		tank.SerialNumber.ShouldBe("12345");
		tank.TankVolumeInMetersCubed.ShouldBe(0.015f);
		tank.Purchase.ShouldNotBeNull();
		tank.ServiceIntervalInDays.ShouldBe(730);
		tank.NextServiceDate.ShouldNotBeNull();
	}
}
using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TankDataTests
{
	private const string Xml = """
	                           <tankdata id="69420">
	                               <link ref="air"/>
	                               <tankvolume>0.01</tankvolume>
	                               <tankpressurebegin>20000000.0</tankpressurebegin>
	                               <tankpressureend>1.0</tankpressureend>
	                               <!-- because the breathing consumption volume is given - in [m^3/s] units! - -->
	                               <!-- the end pressure information can be omitted -->
	                               <!-- 20 litres / minute ^= 0.00033333... m^3/s -->
	                               <breathingconsumptionvolume>0.000333333333</breathingconsumptionvolume>
	                           </tankdata>
	                           """;
	
	[Fact]
	public void CanReadTankData()
	{
		XmlSerializer serializer = new(typeof(TankData));
		TankData tankData = serializer.Deserialize<TankData>(Xml);
		tankData.Id.ShouldBe("69420");
		tankData.TankVolumeInMetersCubed.ShouldBe(0.01f);
		tankData.TankPressureBeginInPascals.ShouldBe(20000000.0f);
		tankData.TankPressureEndInPascals.ShouldBe(1.0f);
		tankData.BreathingConsumptionVolumeInMetersCubedPerSecond.ShouldBe(0.000333333333f);
	}
}
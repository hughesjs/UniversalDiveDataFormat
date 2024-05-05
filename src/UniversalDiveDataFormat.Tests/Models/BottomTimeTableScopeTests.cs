using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BottomTimeTableScopeTests
{
	private const string Xml = """
	                           <bottomtimetablescope>
	                               <!-- beginning with a depth of 5 m, deepest depth 60 m, increment 5 m -->
	                               <divedepthbegin>5.0</divedepthbegin>
	                               <divedepthend>60.0</divedepthend>
	                               <divedepthstep>5.0</divedepthstep>
	                               <!-- calculate table for different breathing gas consumption values: -->
	                               <!-- beginning with 10 liters per minute, greatest BCV 30 l/min, increment 5 l/min -->
	                               <!-- UDDF uses only SI units => l/min -> m^3/s -->
	                               <breathingconsumptionvolumebegin>0.00016666667</breathingconsumptionvolumebegin>
	                               <breathingconsumptionvolumeend>0.0005</breathingconsumptionvolumeend>
	                               <breathingconsumptionvolumestep>0.000083333333</breathingconsumptionvolumestep>
	                               <!-- beginning with a tank volume of 10 litres, end with 20 l, increment 5 l -->
	                               <tankvolumebegin>0.01</tankvolumebegin>
	                               <tankvolumeend>0.02</tankvolumeend>
	                               <tankvolumestep>0.005</tankvolumestep>
	                               <!-- fill pressure 200 bar, reserve pressure 40 bar -->
	                               <tankpressurebegin>2.0e7</tankpressurebegin>
	                               <tankpressurereserve>4.0e6</tankpressurereserve>
	                           </bottomtimetablescope>
	                           """;

	[Fact]
	public void CanReadBottomTimeTableScope()
	{
		XmlSerializer serializer = new(typeof(BottomTimeTableScope));
		BottomTimeTableScope bottomTimeTableScope = serializer.Deserialize<BottomTimeTableScope>(Xml);
		bottomTimeTableScope.BreathingConsumptionVolumeBeginInCubicMetersPerSecond.ShouldBe(0.00016666667f);
		bottomTimeTableScope.BreathingConsumptionVolumeEndInCubicMetersPerSecond.ShouldBe(0.0005f);
		bottomTimeTableScope.BreathingConsumptionVolumeStepInCubicMetersPerSecond.ShouldBe(0.000083333333f);
		bottomTimeTableScope.DiveDepthBeginInMeters.ShouldBe(5.0f);
		bottomTimeTableScope.DiveDepthEndInMeters.ShouldBe(60.0f);
		bottomTimeTableScope.DiveDepthStepInMeters.ShouldBe(5.0f);
		bottomTimeTableScope.TankPressureBeginInPascal.ShouldBe(200.0e7f);
		bottomTimeTableScope.TankPressureReserveInPascal.ShouldBe(40.0e6f);
		bottomTimeTableScope.TankVolumeBeginInCubicMeters.ShouldBe(10.0f);
		bottomTimeTableScope.TankVolumeEndInCubicMeters.ShouldBe(20.0f);
		bottomTimeTableScope.TankVolumeStepInCubicMeters.ShouldBe(5.0f);
	}

}
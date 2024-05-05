using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TableScopeTests
{
	private const string Xml = """
	                           <tablescope>
	                               <!-- height above sea level for which the table is to be calculated -->
	                               <altitude>0.1</altitude>
	                               <!-- beginning with a depth of 3 m, maximum depth 30 m, increment 3 m  -->
	                               <divedepthbegin>3.0</divedepthbegin>
	                               <divedepthend>30.0</divedepthend>
	                               <divedepthstep>3.0</divedepthstep>
	                               <!-- maximum bottom time 30 minutes, to be taken into account for the table -->
	                               <bottomtimemaximum>1800.0</bottomtimemaximum>
	                               <!-- minimum bottom time 5 minutes, to be taken into account for the table -->
	                               <bottomtimeminimum>300.0</bottomtimeminimum>
	                               <!-- at beginning (at minimum dive depth) increment of 10 minutes -->
	                               <bottomtimestepbegin>600.0</bottomtimestepbegin>
	                               <!-- at the end (at maximum dive depth) increment of 1 minute -->
	                               <!-- Schrittweite auf der maximalen Tauchtiefe 1 Minute -->
	                               <bottomtimestepend>60.0</bottomtimestepend>
	                           </tablescope>
	                           """;
	
	[Fact]
	public void CanReadTableScope()
	{
		XmlSerializer serializer = new(typeof(TableScope));
		TableScope tableScope = serializer.Deserialize<TableScope>(Xml);
		tableScope.AltitudeInMeters.ShouldBe(0.1f);
		tableScope.DiveDepthBeginInMeters.ShouldBe(3.0f);
		tableScope.DiveDepthEndInMeters.ShouldBe(30.0f);
		tableScope.DiveDepthStepInMeters.ShouldBe(3.0f);
		tableScope.BottomTimeMaximumInSeconds.ShouldBe(1800.0f);
		tableScope.BottomTimeMinimumInSeconds.ShouldBe(300.0f);		
		tableScope.BottomTimeStepBeginInSeconds.ShouldBe(600.0f);
		tableScope.BottomTimeStepEndInSeconds.ShouldBe(60.0f);
	}	
}
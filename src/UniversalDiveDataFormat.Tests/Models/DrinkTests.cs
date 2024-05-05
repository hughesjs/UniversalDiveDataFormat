using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DrinkTests
{
	private const string Xml = """
	                           <drink>
	                               <name>Tequila Sunrise</name>
	                               <!-- not periodically taken :-) -->
	                               <periodicallytaken>no</periodicallytaken>
	                               <!-- taken 30 minutes before the dive -->
	                               <timespanbeforedive>1800.0</timespanbeforedive>
	                               <notes>
	                                   <para>
	                                       Maybe not very good so short-timed before the dive,
	                                       but I couldn't resist the invitation...
	                                   </para>
	                               </notes>
	                           </drink>
	                           """;
	
	[Fact]
	public void CanReadDrink()
	{
		XmlSerializer serializer = new(typeof(Drink));
		Drink drink = serializer.Deserialize<Drink>(Xml);
		drink.Name.ShouldBe("Tequila Sunrise");
		drink.PeriodicallyTaken.ShouldBe(PeriodicallyTaken.No);
		drink.TimeSpanBeforeDiveInSeconds.ShouldBe(1800.0f);
		drink.Notes.ShouldNotBeNull();
	}
}
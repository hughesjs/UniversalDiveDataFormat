using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class BottomTimeTableTests
{
	private const string Xml = """
	                           <bottomtimetable id="max_bottime_table_air_0m">
	                               <title>Kai's Maximal Bottom Time Table for sea level</title>
	                               <!-- reference to the prior calculated dive table as a basis -->
	                               <!-- to calculate now the "maximum bottom time table" -->
	                               <link ref="divetable_air_0m"/>
	                               <!-- in the following information concerning the output file -->
	                               <output>
	                                   <!-- output in English language -->
	                                   <lingo>en</lingo>
	                                   <!-- ASCII format (-> file extension ".txt") -->
	                                   <fileformat>ascii</fileformat>
	                                   <!-- name of output file (extension ".txt" must not be given!) -->
	                                   <filename>kais_mbt_table</filename>
	                                   <!-- headline for table -->
	                                   <headline>Kai's Maximal Bottom Time Table for sea level</headline>
	                                   <!-- explaining text, or some othe remarks -->
	                                   <remark>
	                                       This is Kai's "Maximal Bottom Time Table" for scuba dives in the sea
	                                       with air as breathing gas to be used. If the diver has to obey some
	                                       decompression stops using the full bottom time, a "d" is put in front
	                                       of the numerical value. These necessary deco stops are considered in
	                                       the calculated bottom time given.
	                                   </remark>
	                               </output>
	                               <applicationdata>
	                                   <!-- here software specific statements -->
	                               </applicationdata>
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
	                           </bottomtimetable>
	                           """;
	
	[Fact]
	public void CanReadBottomTimeTable()
	{
		XmlSerializer serializer = new(typeof(BottomTimeTable));
		BottomTimeTable bottomTimeTable = serializer.Deserialize<BottomTimeTable>(Xml);
		bottomTimeTable.Id.ShouldBe("max_bottime_table_air_0m");
		bottomTimeTable.Links.Count.ShouldBe(1);
		bottomTimeTable.ApplicationData.ShouldBeNull();
		bottomTimeTable.BottomTimeTableScope.ShouldNotBeNull();
		bottomTimeTable.Output.ShouldNotBeNull();
		bottomTimeTable.Title.ShouldBe("Kai's Maximal Bottom Time Table for sea level");
	}
}
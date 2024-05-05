using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TableGenerationTests
{
	private const string Xml = """
	                           <tablegeneration>
	                               <!-- calculation of ascent profiles -->
	                               <calculateprofile>
	                                   <profile id="profile-1">
	                                       ...
	                                   </profile>
	                                   <profile id="profile-2">
	                                       ...
	                                   </profile>
	                                   <!-- here more <profile>s can be given -->
	                                   ...
	                               </calculateprofile>
	                               <!-- calculation of decompression tables -->
	                               <calculatetable>
	                                   <table id="0-700m">
	                                       <!-- calculate a certain table -->
	                                       ...
	                                   </table>
	                                   <table id="701-1500m">
	                                       <!-- calculate a certain table -->
	                                       ...
	                                   </table>
	                                   <!-- here more <table>s can be given  -->
	                                   ...
	                               </calculatetable>
	                               <!-- calculation of "maximum bottom time" tables -->
	                               <!-- First, at least one deco table must have been calculated, -->
	                               <!-- on whose basis a "MBT" table can be generated.            -->
	                               <!-- Therefore the first element inside <table id="...">       -->
	                               <!-- must be a reference via <link ref="..."> to the       -->
	                               <!-- parent table.                                             -->
	                               <calculatebottomtimetable>
	                                   <!-- calculate a certain table -->
	                                   <table id="mgt0-700m">
	                                       <link ref="0-700m"/>
	                                       ...
	                                   </table>
	                                   <!-- here more <table>s can be given  -->
	                                   ...
	                               </calculatebottomtimetable>
	                           </tablegeneration>
	                           """;
	
	[Fact]
	public void CanReadTableGeneration()
	{
		XmlSerializer serializer = new(typeof(TableGeneration));
		TableGeneration tableGeneration = serializer.Deserialize<TableGeneration>(Xml);
		tableGeneration.CalculateBottomTimeTable.ShouldNotBeNull();
		tableGeneration.CalculateProfile.ShouldNotBeNull();
		tableGeneration.CalculateTable.ShouldNotBeNull();
	}
}
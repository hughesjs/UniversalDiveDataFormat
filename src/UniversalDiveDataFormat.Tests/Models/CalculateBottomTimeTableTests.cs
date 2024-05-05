using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class CalculateBottomTimeTableTests
{
	private const string Xml = """
	                           <calculatebottomtimetable>
	                                  <bottomtimetable id="max_bottime_table_air_0m">
	                                      
	                                  </bottomtimetable>  
	                                  <bottomtimetable id="max_bottime_table_air_3m">
	                                      
	                                  </bottomtimetable>
	                                  
	                              </calculatebottomtimetable>
	                           """;
	
	[Fact]
	public void CanReadCalculateBottomTimeTable()
	{
		XmlSerializer serializer = new(typeof(CalculateBottomTimeTable));
		CalculateBottomTimeTable calculateBottomTimeTable = serializer.Deserialize<CalculateBottomTimeTable>(Xml);
		calculateBottomTimeTable.BottomTimeTables.Count.ShouldBe(2);
	}
}
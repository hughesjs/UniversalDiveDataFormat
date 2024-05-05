using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class TableTests
{
	private const string Xml = """
	                           <table id="decotable_nitrox4060_0m">
	                               <title>Table for Sealevel - Nitrox 40/60</title>
	                               <!-- cross reference to a previous dive ("dive500"); on basis of the tissue -->
	                               <!-- saturation due to this previous dive now the table is to be generated -->
	                               <link ref="dive500"/>
	                               <!-- cross reference to the breathing gas to be used -->
	                               <link ref="nitrox4060"/>
	                               <surfaceintervalbeforedive>
	                                   <!-- a pause of 3 h between dives -->
	                                   <passedtime>10800.0</passedtime>
	                               </surfaceintervalbeforedive>
	                               <!-- salt water -->
	                               <density>1030.0</density>
	                               <!-- in the following statements for output into a file -->
	                               <output>
	                                   <!-- output language is English -->
	                                   <lingo>en</lingo>
	                                   <!-- PDF format (-> file extension ".pdf") -->
	                                   <fileformat>pdf</fileformat>
	                                   <!-- name of output file (extension ".pdf" must not be given!) -->
	                                   <filename>table_nitrox4060_0m</filename>
	                                   <!-- headline for table -->
	                                   <headline>Table for Sealevel - Nitrox 40/60</headline>
	                                   <!-- some illustrative text or other remarks -->
	                                   <remark>
	                                       This is a special table for our proposed descent to the shallow south of Gabiniere.
	                                   </remark>
	                               </output>
	                               <applicationdata>
	                                   <!-- here software specific data -->
	                               </applicationdata>
	                               <decomodel>zh-l16</decomodel>
	                               <!-- take into account deep stops of 1 minute length -->
	                               <deepstoptime>60.0</deepstoptime>
	                               <!-- maximum ascending rate 10 m/min -->
	                               <maximumascendingrate>0.1666666667</maximumascendingrate>
	                               <tablescope>
	                                   <!-- height above sea level for which the table is to be calculated -->
	                                   <altitude>0.0</altitude>
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
	                           </table>
	                           """;
	
	[Fact]
	public void CanReadTable()
	{
		XmlSerializer serializer = new(typeof(Table));
		Table table = serializer.Deserialize<Table>(Xml);
		table.Id.ShouldBe("decotable_nitrox4060_0m");
		table.Links.Count.ShouldBe(2);
		table.ApplicationData.ShouldBeNull();
		table.TableScope.ShouldNotBeNull();
		table.DecoModel.ShouldNotBeNull();
		table.DeepStopTimeInSeconds.ShouldBe(60.0f);
		table.MaximumAscendingRateInCubicMetersPerSecond.ShouldBe(0.1666666667f);
		table.Output.ShouldNotBeNull();
		table.Title.ShouldBe("Table for Sealevel - Nitrox 40/60");
	}
}